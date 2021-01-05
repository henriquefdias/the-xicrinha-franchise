using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSpawner : MonoBehaviour
{
    public GameObject[] m_EnemiesArray;
    private Transform m_Spawner;
    private Renderer m_Renderer;
    private float y1, y2;

    void Start()
    {
        m_Spawner = GetComponent<Transform>();
        m_Renderer = GetComponent<Renderer>();
        //m_Spawner.position = new Vector3(0, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height)).y + 2);
        m_Spawner.position = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0)).x * -1 - 2, 0);
        //m_Spawner.localScale = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 1.5f, 0)).x, m_Spawner.localScale.y);
        m_Spawner.localScale = new Vector3(m_Spawner.localScale.x, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height * 1.5f)).y);
        y1 = transform.position.y - m_Renderer.bounds.size.y / 2;
        y2 = transform.position.y + m_Renderer.bounds.size.y / 2;
        InvokeRepeating("Spawn", 4.0f, 3.0f);
    }

    void Update()
    {

    }

    public void Spawn()
    {
        GameObject rdmEnemy = m_EnemiesArray[Random.Range(0, m_EnemiesArray.Length)];
        Vector2 spawnPoint = new Vector2(transform.position.x, Random.Range(y1, y2));
        Instantiate(rdmEnemy, spawnPoint, Quaternion.identity);
    }
}
