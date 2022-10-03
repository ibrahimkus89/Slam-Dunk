using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platform;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (platform.transform.position.x > -1.30)
            {
                platform.transform.position = Vector3.Lerp(platform.transform.position, new Vector3(platform.transform.position.x - .3f, platform.transform.position.y, platform.transform.position.z), .050f);

            }

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if ( platform.transform.position.x < 1.30)
            {
                platform.transform.position = Vector3.Lerp(platform.transform.position, new Vector3(platform.transform.position.x + .3f, platform.transform.position.y, platform.transform.position.z), .050f);

            }


        }

    }
}
