using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;

public class DoneButtons: MonoBehaviour
{
    public DialogueManager DialogueManager;

    void Update() {  
        if (Input.GetMouseButtonDown(0)) {  
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.name == "DoneButton") {  
                    DialogueManager.OnDoneButtonClick();
                }  
            }  
        }  
    }  
}