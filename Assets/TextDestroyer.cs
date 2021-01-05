using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDestroyer : MonoBehaviour
{
    private Text m_Text;
    private float m_ElapsedTime;
    void Start()
    {
        m_Text = GetComponent<Text>();
        m_Text.color = Random.ColorHSV();
    }

    void Update()
    {
        m_ElapsedTime += Time.deltaTime;
        if (m_ElapsedTime > 3.0f) Destroy(gameObject);
    }
}
