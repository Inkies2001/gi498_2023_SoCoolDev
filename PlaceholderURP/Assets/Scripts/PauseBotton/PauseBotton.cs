using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBotton : MonoBehaviour
{

    public GameObject pauseMenu;

    public GameObject SettingMenu;

    public static bool isPause;

    public static bool isSetting;
    void Start()
    {
        pauseMenu.SetActive(false);

        SettingMenu.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                ResumeGame();

            }

            if (isSetting)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    SettingMenu.SetActive(false);
                    Time.timeScale = 1f;
                    PauseGame();
                }
            }
            
        }
    } 

   public void PauseGame()
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isPause = true;
        }

   public void ResumeGame()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isPause = false;
        }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void SettingAtive()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SettingMenu.SetActive(true);
        isSetting = true;
       

    }

    public void SettingBack()
    {
        SettingMenu.SetActive(false );
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
