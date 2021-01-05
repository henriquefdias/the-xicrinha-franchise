using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toquesNaTela : MonoBehaviour
{

    int m_ToquesQtd = 0;
    public Text m_Texto;
    public GameObject m_PlusOne;

    // void Update()
    // {
    //     toquesQtd += Input.touchCount;
    // 	texto.text = toquesQtd.ToString();
    //     if (Input.GetButtonDown("Fire1"))
    //     {
    //         Debug.Log("BALA");
    //     }
    // }

    //private void Update()
    //{
    //    if (Input.touchCount == 1)
    //    {
    //        Touch touch = Input.GetTouch(0);
    //        if (touch.phase == TouchPhase.Began)
    //        {
    //            m_ToquesQtd += 1;
    //            m_Texto.text = m_ToquesQtd.ToString();
    //            m_Texto.color = Random.ColorHSV();
    //        }
    //    }
    //}

    public void PlusOne()
    {
        m_ToquesQtd += 1;
        m_Texto.text = m_ToquesQtd.ToString();
        m_Texto.color = Random.ColorHSV();
    }

    public void LessOne()
    {
        m_ToquesQtd -= 1;
        m_Texto.text = m_ToquesQtd.ToString();
        m_Texto.color = Random.ColorHSV();
    }
}
