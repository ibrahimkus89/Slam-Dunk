using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [Header("---LEVEL BASIC OBJECTS")]
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject BasketObj;
    [SerializeField] private GameObject BasketEnlargeObj;
    [SerializeField] private GameObject[] FeaturePoints;



    [Header("---UI OBJECTS")]
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

        Invoke("FeatureCreate", 3f);
    }

    void FeatureCreate()
    {
        int randomNumber = Random.Range(0,FeaturePoints.Length-1);

        BasketEnlargeObj.transform.position = FeaturePoints[randomNumber].transform.position;
        BasketEnlargeObj.SetActive(true);

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

        if (basketNumber ==1)
        {
            FeatureCreate();
        }
    }

    public void Lost()
    {
        Debug.Log("Lose");

    }

    public void BasketEnlarge()
    {
        BasketObj.transform.localScale = new Vector3(55f, 55f, 55f);

    }
}
