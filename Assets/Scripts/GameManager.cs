using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGamePause;
    private void Start()
    {
        Resume();
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        isGamePause= true;
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
