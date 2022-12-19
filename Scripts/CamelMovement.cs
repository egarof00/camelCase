using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamelMovement : MonoBehaviour
{
    public bool isFacingLeft = true;
    public DialogueManager DialogueManager;
    public TopBarUI TopBarUI;
    public SpriteRenderer camelSpriteRenderer;
    
    void Update()
    {
        if (!DialogueManager.isTalking && !TopBarUI.isUIPageOpen)
        {
            MoveCamelHorizontally();
            FlipCamelCorrectDirection();  
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -20.4f, 39f), transform.position.y, transform.position.z);
    }
    
    private void MoveCamelHorizontally()
    {
        transform.Translate(Input.GetAxis("Horizontal") * ImportantVariables.CamelSpeed * Time.deltaTime, 0f, 0f);
    }

    private void FlipCamelCorrectDirection()
    {
        Vector3 camelScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            camelSpriteRenderer.flipX = false;
            isFacingLeft = true;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            camelSpriteRenderer.flipX = true;
            isFacingLeft = false;
        }
        transform.localScale = camelScale;

    }
}
