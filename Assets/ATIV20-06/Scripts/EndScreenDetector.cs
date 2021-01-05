using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenDetector : MonoBehaviour
{
    private Transform m_Detector;
    private Renderer m_Renderer;
    public CoffeeShooter m_Xicrinha;
    void Start()
    {
        m_Detector = GetComponent<Transform>();
        m_Renderer = GetComponent<Renderer>();
        m_Detector.position = new Vector3(0, m_Xicrinha.transform.position.y - 4.0f);
        m_Detector.localScale = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 1.5f, 0)).x, m_Detector.localScale.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            m_Xicrinha.m_Life--;
            Destroy(other.gameObject);
        }
    }
}
