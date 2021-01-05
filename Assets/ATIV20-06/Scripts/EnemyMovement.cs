using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform m_Enemy;
    private float m_Speed;

    void Start()
    {
        m_Enemy = GetComponent<Transform>();
        m_Speed = 4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        m_Enemy.Translate(0, Vector2.down.y * m_Speed * Time.deltaTime, 0);
    }
}
