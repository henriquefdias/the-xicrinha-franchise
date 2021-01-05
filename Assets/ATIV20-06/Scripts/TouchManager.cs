using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    private Transform m_Player;

    void Start()
    {
        m_Player = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                m_Player.position = new Vector2(touchPos.x, m_Player.position.y);
            }
        }
    }
}
