using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(ImportantVariables.InstructionsDuration);
        Destroy(gameObject);
    }
}
