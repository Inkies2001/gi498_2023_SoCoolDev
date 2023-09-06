using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour
{
    [SerializeField] private GameObject dialogueManager;

    private bool mouseOver;

    void Update()
    {
        if (mouseOver && Input.GetMouseButtonDown(0))
        {
            dialogueManager.SetActive(true);
        }


    }

    private void OnMouseEnter()
    {
        mouseOver = true;
    }

    private void OnMouseExit()
    {
        mouseOver = false;
    }
}
