using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camel : MonoBehaviour
{
    public bool isHoveringOverCharacter = false;
    public string characterBeingCollidedWith;
    private void OnCollisionStay(Collision collisionInfo)
    {
        if (isCharacterTagged(collisionInfo))
        {
            isHoveringOverCharacter = true;
            characterBeingCollidedWith = getCollisionTag(collisionInfo);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (isCharacterTagged(other))
        {
            isHoveringOverCharacter = false;
        }
    }

    private bool isCharacterTagged(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mary") || collision.gameObject.CompareTag("Dre") || 
            collision.gameObject.CompareTag("Sandy") || collision.gameObject.CompareTag("Handsel") ||
            collision.gameObject.CompareTag("Althea") || collision.gameObject.CompareTag("Romero") ||
            collision.gameObject.CompareTag("Simon") || collision.gameObject.CompareTag("Amit"))
        {
            return true;
        }

        return false;
    }

    private string getCollisionTag(Collision collision)
    {
        return collision.gameObject.tag;
    }

    public Vector3 getCurrentLocation()
    {
        return gameObject.transform.position;
    }
}
