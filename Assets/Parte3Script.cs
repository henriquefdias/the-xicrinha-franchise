using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Parte3Script : MonoBehaviour
{
    public Camera MainCamera;
    public List<AudioSource> m_Audios;
    public List<GameObject> m_Images;
    private Vector2 screenBounds;

    public void PlayRandomSound()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        int rdm = Random.Range(0, m_Audios.Count);
        m_Audios[rdm].Play();
    }

    public void InstRandomImage()
    {
        Debug.Log(screenBounds.x);
        float rdmPosX = Random.Range(screenBounds.x * -1, screenBounds.x);
        float rdmPosY = Random.Range(screenBounds.y * -1, screenBounds.y);
        Vector3 v3 = new Vector3(rdmPosX, rdmPosY, 0);
        int rdm = Random.Range(0, m_Images.Count);
        Instantiate(m_Images[rdm], v3, Quaternion.identity);
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                PlayRandomSound();
                InstRandomImage();
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Ativ3");
    }
}
