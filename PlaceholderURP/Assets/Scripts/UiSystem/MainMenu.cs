using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.TimeZoneInfo;

public class MainMenu : MonoBehaviour
{
    public Animator transition;

    public float transitiontTime = 1f;

    public void PlayGame()
    {
        StartCoroutine (LoadLevel(0));
       
    }

    public void GotoSettingMenu()
    {
        StartCoroutine(LoadLevel(2));
    }

    public void GotoMianMenu()
    {
        StartCoroutine(LoadLevel(3));
    }

    public void GotoGallery()
    {
        StartCoroutine(LoadLevel(4));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontTime);

       SceneManager.LoadScene(levelIndex);

       
    }
}
