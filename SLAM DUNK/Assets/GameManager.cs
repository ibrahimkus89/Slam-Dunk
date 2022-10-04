using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject platform;

    [SerializeField] private Image[] missionImages;
    [SerializeField] private Sprite missionSprite;
    [SerializeField] private int ballToBeThrown;

    int basketNumber;

    void Start()
    {

        for (int i = 0; i <ballToBeThrown; i++)
        {
            missionImages[i].gameObject.SetActive(true);

        }
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

    public void Basket()
    {
        basketNumber++;
        missionImages[basketNumber - 1].sprite = missionSprite;


        if (basketNumber == ballToBeThrown)
        {
            Debug.Log("Win");
        }
    }

    public void Lost()
    {
        Debug.Log("Lose");

    }
}
