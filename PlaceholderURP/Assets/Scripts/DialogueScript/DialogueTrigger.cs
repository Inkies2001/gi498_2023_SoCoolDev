using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public Animator animator;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        //animator.SetBool("isClose", true);

        Destroy(gameObject);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
      

    }
}
