using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camel;
    public CamelMovement CamelMovement;
    
    // GAME PARAM SCRIPT?
    private float offset = 2;
    private float offsetSmoothing = 2;
    private Vector3 camelPosition;

    void Update()
    {
        FollowPlayerWithOffset();
    }

    private void FollowPlayerWithOffset()
    {
        camelPosition = new Vector3(camel.transform.position.x, camel.transform.position.y + 1.5f,
            transform.position.z);
        OffsetCamera();
        transform.position = Vector3.Lerp(transform.position, camelPosition,
            offsetSmoothing * Time.deltaTime);
    }
    
    private void OffsetCamera()
    {
        if (CamelMovement.isFacingLeft)
        {
            camelPosition = new Vector3(camelPosition.x - offset, camel.transform.position.y + 1.5f,
                transform.position.z);
        }else
        {
            camelPosition = new Vector3(camelPosition.x + offset, camel.transform.position.y + 1.5f,
                transform.position.z);
        }
    }
}
