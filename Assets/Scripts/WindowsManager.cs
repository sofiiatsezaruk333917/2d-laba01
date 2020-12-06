using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowsManager : MonoBehaviour
{
    public GameObject pauseWindow;
    public GameObject fadeOverlay;

    public void OnPressResume()
    {
        Time.timeScale = 1f;
        pauseWindow.active = false;
        fadeOverlay.active = false;
    }

    public void OnPressMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }




}