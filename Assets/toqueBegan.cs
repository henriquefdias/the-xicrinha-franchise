using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toqueBegan : MonoBehaviour
{
    public GameObject m_Cubo;
    int m_Valor = 0;

    void Start()
    {

    }


    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Instantiate(m_Cubo, new Vector3(m_Valor, m_Valor, m_Valor), Quaternion.identity);
            m_Valor += 1;
        }
    }
}
