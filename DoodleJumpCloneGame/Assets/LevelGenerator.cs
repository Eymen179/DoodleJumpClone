using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformObject;
    public GameObject dangerousPlatformObject;
    public int platformCount, dangerousPlatformCount;
    public float minX, minY, maxX, maxY;
    public float dMinY, dMaxY;
    void Start()
    {
        Vector3 clonePosition = new Vector3();
        
        for(int i = 0; i < platformCount; i++)
        {
            clonePosition.x = Random.Range(minX, maxX);
            clonePosition.y = Random.Range(minY, maxY);
            Instantiate(platformObject, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < dangerousPlatformCount; i++)
        {
            clonePosition.x = Random.Range(minX, maxX);
            clonePosition.y = Random.Range(dMinY, dMaxY);
            Instantiate(dangerousPlatformObject, clonePosition, Quaternion.identity);
        }
    }

}
