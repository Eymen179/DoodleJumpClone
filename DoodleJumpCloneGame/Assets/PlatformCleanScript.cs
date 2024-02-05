using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCleanScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float randomX = Random.Range(-5f, 6f);
        float randomY = Random.Range(10f, 12f);

        if(collision.tag == "Platform")
        {
             collision.transform.position = new Vector3(randomX, collision.transform.position.y + randomY, collision.transform.position.z);
        }
    }
}
