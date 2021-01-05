using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RaycastTest : MonoBehaviour
{
    public Transform m_Player;
    public float m_Speed;
    public string m_Button;
    public JoystickManager m_UIDetector;


    void Start()
    {
        m_Speed = 5.0f;
        m_Button = "";
    }

    public void ButtonDetector(string button)
    {
        m_Button = button;
    }
    public void ButtonCleaner()
    {
        m_Button = "a";
        Invoke("RealButtonCleaner", 0.1f);
    }
    public void RealButtonCleaner()
    {
        m_Button = "";
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    m_Player.Translate(Vector2.up * m_Speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    m_Player.Translate(Vector2.down * m_Speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    m_Player.Translate(Vector2.left * m_Speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    m_Player.Translate(Vector2.right * m_Speed * Time.deltaTime);
        //}
        // Check if there is a touch

        if (m_Button == "Up")
        {
            Debug.Log("up");
            m_Player.Translate(Vector2.up * m_Speed * Time.deltaTime);
        }
        if (m_Button == "Right")
        {
            Debug.Log("Right");
            m_Player.Translate(Vector2.right * m_Speed * Time.deltaTime);
        }
        if (m_Button == "Down")
        {
            Debug.Log("Down");
            m_Player.Translate(Vector2.down * m_Speed * Time.deltaTime);
        }
        if (m_Button == "Left")
        {
            Debug.Log("Left");
            m_Player.Translate(Vector2.left * m_Speed * Time.deltaTime);
        }
    }
}
