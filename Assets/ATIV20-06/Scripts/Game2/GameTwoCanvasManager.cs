using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTwoCanvasManager : MonoBehaviour
{
    public BuleManager m_Bule;
    public Text m_LifeText;
    public Text m_ScoreText;
    public Text m_GameOver;
    private bool m_IsGameOn;

    void Start()
    {
        m_IsGameOn = true;
    }

    void Update()
    {
        if (m_IsGameOn)
        {
            m_LifeText.text = "Life: " + m_Bule.m_Life;
            m_ScoreText.text = "Score: " + m_Bule.m_Score;
            if (m_Bule.m_Life <= 0)
            {
                m_IsGameOn = false;
                m_GameOver.gameObject.SetActive(true);
                Invoke("Loader", 3.0f);
            }
        }
    }

    private void Loader()
    {
        SceneManager.LoadScene("Game2");
    }
}
