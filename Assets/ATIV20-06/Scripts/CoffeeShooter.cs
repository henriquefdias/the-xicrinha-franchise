using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoffeeShooter : MonoBehaviour
{
    private int tapCount;
    private float doubleTapTimer;
    private float m_ElapsedTime;
    public int m_Life;
    public int m_CoffeeReservatory;
    public int m_CoffeeReservatoryLimit;
    public int m_CoffeeWasteInShot;
    public Text m_CoffeeReservatoryText;
    public Text m_LifeText;
    public Text m_GameOver;
    public Text m_Tempo;
    private bool m_IsGameOn;

    public GameObject m_CoffeeBullet;
    public GameObject m_BuleReload;

    void Start()
    {
        m_ElapsedTime = 0.0f;
        m_IsGameOn = true;
        m_CoffeeReservatory = 200;
        m_CoffeeReservatoryLimit = 500;
        m_CoffeeWasteInShot = 10;
        m_Life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        m_ElapsedTime += Time.deltaTime;

        if (Input.touchCount > 1)
        {
            if (m_CoffeeReservatory <= m_CoffeeReservatoryLimit)
            {
                m_BuleReload.SetActive(true);
                m_CoffeeReservatory += Input.touchCount; 
            }
        }
        else
        {
            m_BuleReload.SetActive(false);
        }

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            tapCount++;
        }
        if (tapCount > 0)
        {
            doubleTapTimer += Time.deltaTime;
        }
        if (tapCount >= 2)
        {
            if (m_CoffeeReservatory >= m_CoffeeWasteInShot)
            {
                Shoot();
            }

            doubleTapTimer = 0.0f;
            tapCount = 0;
        }
        if (doubleTapTimer > 0.5f)
        {
            doubleTapTimer = 0f;
            tapCount = 0;
        }

        if (m_IsGameOn)
        {
            m_Tempo.text = "Tempo: " + Mathf.Round(m_ElapsedTime);
            m_LifeText.text = "Life: " + m_Life;
            m_CoffeeReservatoryText.text = "Café no bule: " + m_CoffeeReservatory;
        }

        if (m_Life <= 0)
        {
            m_GameOver.gameObject.SetActive(true);
            m_IsGameOn = false;
            Invoke("LoadScene", 3.0f);
        }
        
    }

    private void Shoot()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y);
        Instantiate(m_CoffeeBullet, pos, Quaternion.identity);
        m_CoffeeReservatory -= m_CoffeeWasteInShot;
    }

    private void LoadScene()
    {
        SceneManager.LoadScene("Game1");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("inimigio bateu na xicara");
            m_Life -= 1;
            Destroy(other.gameObject);
        }
    }
}
