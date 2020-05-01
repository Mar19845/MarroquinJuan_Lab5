using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;
    public GameObject OnGameUI;
    
    
  
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        GamePaused = false;
        OnGameUI.SetActive(true);
        
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale=0f;
        GamePaused = true;
        OnGameUI.SetActive(false);
        
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
}
