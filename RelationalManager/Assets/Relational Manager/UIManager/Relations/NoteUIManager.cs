using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteUIManager : MonoBehaviour
{
    public UIManager uiManager;

    [Header("Instantiable Objects")]
    public GameObject notePrefab;
    public bool canMakeNotes;

    public void CreateNote()
    {
        if (canMakeNotes)
        {
            string text = uiManager.noteTextBox.text;
            uiManager.noteTextBox.text = "";
            GameObject obj = Instantiate(notePrefab);
            obj.transform.parent = uiManager.canvasTransform;
            obj.transform.position = Vector3.zero;
        }
    }
}
