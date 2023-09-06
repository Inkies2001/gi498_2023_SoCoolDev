using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue2 : MonoBehaviour
{
    [SerializeField] private string[] sentences1;

    [SerializeField] private string[] sentences2;

    public GameObject[] answers;

    public TextMeshProUGUI dialogueText;

    private int index;

    private bool canContinue;

    private int option;

    void Start()
    {
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(true);
        }

        index = 0;
    }

    private void Update()
    {
        if (canContinue && Input.GetMouseButtonDown(0))
        {
            index += 1;

            if (option == 1 && sentences1.Length > index)
            {
                dialogueText.text = sentences1[index];
            }
            else if (option == 2 && sentences2.Length > index)
            {
                dialogueText.text = sentences2[index];
            }
            else
            {
                dialogueText.gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }

    public void DialogueOpion1()
    {
        option = 1;

        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }

        canContinue = true;

        dialogueText.gameObject.SetActive(true);

        dialogueText.text = (sentences1[index]);


    }

    public void DialogueOption2()
    {

        option = 2;

        dialogueText.gameObject.SetActive(true);

        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }
        canContinue = true;

        dialogueText.text = (sentences2[index]);

    }
}