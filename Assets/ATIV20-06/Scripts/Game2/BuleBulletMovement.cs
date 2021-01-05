using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuleBulletMovement : MonoBehaviour
{
    private float m_Speed = 20.0f;
    private Rigidbody2D m_Rb;
    private Target m_Target;
    private Vector2 m_MoveDirection;
    private BuleManager m_Bule;

    void Start()
    {
        m_Bule = FindObjectOfType<BuleManager>();
        m_Rb = GetComponent<Rigidbody2D>();
        m_Target = GameObject.FindObjectOfType<Target>();
        m_MoveDirection = (m_Target.transform.position - transform.position).normalized * m_Speed;
        m_Rb.velocity = new Vector2(m_MoveDirection.x, m_MoveDirection.y);
        Destroy(gameObject, 4.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            m_Bule.m_Score += 10;
            Destroy(other.gameObject);
        }
    }
}
