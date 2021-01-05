using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuleManager : MonoBehaviour
{
    public GameObject m_Target;
    public GameObject m_Bullet;
    public int m_Life;
    public int m_Score;

    void Start()
    {
        m_Life = 3;
        m_Score = 0;
    }

    public void AimTarget()
    {
        Debug.Log("mirou");
        Target goTarget = GameObject.FindObjectOfType<Target>();
        if (goTarget != null)
            Destroy(goTarget.gameObject);

        Instantiate(m_Target, Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), Quaternion.identity); // funcionou sem isso? no toque do celular?
        //Instantiate(m_Target, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
    }

    public void ShootCoffee()
    {
        Instantiate(m_Bullet, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            m_Life -= 1;
            Destroy(other.gameObject);
        }
    }
}
