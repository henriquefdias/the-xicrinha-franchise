using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] m_EnemiesArray;
    private Transform m_Spawner;
    private Renderer m_Renderer;
    private float x1, x2;

    void Start()
    {
        m_Spawner = GetComponent<Transform>();
        m_Renderer = GetComponent<Renderer>();
        m_Spawner.position = new Vector3(0, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height)).y + 2);
        m_Spawner.localScale = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 1.5f, 0)).x, m_Spawner.localScale.y);
        x1 = transform.position.x - m_Renderer.bounds.size.x / 2;
        x2 = transform.position.x + m_Renderer.bounds.size.x / 2;
        InvokeRepeating("Spawn", 1.0f, 1.0f);
    }

    void Update()
    {

    }

    public void Spawn()
    {
        GameObject rdmEnemy = m_EnemiesArray[Random.Range(0, m_EnemiesArray.Length)];
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(rdmEnemy, spawnPoint, Quaternion.identity);
    }
}
