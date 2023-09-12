using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Animator transition;

    public float transitiontTime = 1f;
    
    void Update()
    {
        
        if(Input.GetKeyUp(KeyCode.Space))
        {
            LoadNextLevel();
        }
        
    }

    public void LoadNextLevel()
    {
       StartCoroutine (LoadLevel(0));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontTime);

        SceneManager.LoadScene(levelIndex);
    }
}
