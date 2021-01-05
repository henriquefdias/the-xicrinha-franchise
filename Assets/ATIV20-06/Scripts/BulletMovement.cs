using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Transform m_Bullet;
    private float m_Speed;

    void Start()
    {
        m_Bullet = GetComponent<Transform>();
        m_Speed = 7.5f;
    }

    void Update()
    {
        m_Bullet.Translate(0, Vector2.up.y * m_Speed * Time.deltaTime, 0);
        if (m_Bullet.position.y > Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height)).y + 2)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("PEGA NO BREU");
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("BALA BATEU NO IMNIMIGO");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
