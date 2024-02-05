using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform characterPosition;
    public Transform groundPosition;
    void Update()
    {
        if (characterPosition.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, characterPosition.position.y, transform.position.z);
            groundPosition.position = new Vector3(groundPosition.position.x, characterPosition.position.y-8, groundPosition.position.z);
        }
    }

}
