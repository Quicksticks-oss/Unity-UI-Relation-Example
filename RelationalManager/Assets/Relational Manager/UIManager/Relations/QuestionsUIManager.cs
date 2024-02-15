using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsUIManager : MonoBehaviour
{
    public UIManager uiManager;

    public string[] questions;

    public bool canAskQuestions;
    private int index;

    public void AskQuestion()
    {
        if (canAskQuestions)
        {
            string question = questions[index];
            uiManager.titleText.text = question;
            Text placeholder = uiManager.noteTextBox.placeholder as Text;
            placeholder.text = question;
            index++;
            if (index >= questions.Length) {
                index = 0;
            }
        }
    }

    string GetRandomQuestion()
    {
        int index = Random.Range(0, questions.Length);
        return questions[index];
    }
}
