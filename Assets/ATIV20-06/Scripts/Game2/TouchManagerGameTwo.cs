using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchManagerGameTwo : MonoBehaviour
{
    public BuleManager m_Bule;
    private bool m_IsAimOn;
    public RaycastTest m_RT;

    void Start()
    {
        m_IsAimOn = false;
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            if (m_RT.m_Button.Equals(""))
            {
                if (!m_IsAimOn)
                {
                    m_Bule.AimTarget();
                    m_IsAimOn = true;
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!m_IsAimOn)
            {
                m_Bule.AimTarget();
                m_IsAimOn = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            m_Bule.ShootCoffee();
            m_IsAimOn = false;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            if (m_RT.m_Button.Equals(""))
            {
                m_Bule.ShootCoffee();
                m_IsAimOn = false;
            }
        }
    }
}
