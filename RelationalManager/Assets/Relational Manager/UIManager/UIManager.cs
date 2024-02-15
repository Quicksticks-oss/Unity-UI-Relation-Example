using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;
    [Header("Relations")]
    public QuestionsUIManager questionsUIManager;
    public NoteUIManager noteUIManager;
    public TutorialUIManager tutorialUIManager;

    [Header("Events")]
    public UnityEvent submitEvent;

    [Header("UI Items")]
    public Button submitButton;
    public InputField noteTextBox;
    public Text titleText;
    [Space(10)]
    public Transform canvasTransform;

    public void SubmitActivation() {
        submitEvent.Invoke();
    }
}
