using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGamePause;
    private void Start()
    {
        
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        isGamePause= true;
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
