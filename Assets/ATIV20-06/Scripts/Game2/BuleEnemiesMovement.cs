using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuleEnemiesMovement : MonoBehaviour
{
    private Transform m_Enemy;
    private float m_Speed;

    void Start()
    {
        m_Enemy = GetComponent<Transform>();
        m_Speed = 4.0f;
        Destroy(gameObject, 4.0f);
    }

    void Update()
    {
        if(name.Contains("U"))
            m_Enemy.Translate(0, Vector2.down.y * m_Speed * Time.deltaTime, 0);
        
        if(name.Contains("R"))
            m_Enemy.Translate(Vector2.left.x * m_Speed * Time.deltaTime, 0, 0);
        
        if(name.Contains("D"))
            m_Enemy.Translate(0, Vector2.up.y * m_Speed * Time.deltaTime, 0);
        
        if(name.Contains("L"))
            m_Enemy.Translate(Vector2.right.x * m_Speed * Time.deltaTime, 0, 0);
    }
}
