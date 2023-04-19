using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Emeralds : MonoBehaviour
{

    public GameObject emeralds;
    public List<GameObject> emeraldList;

    public int emeraldsCount;
    public int emeraldsMax;

    void Start()
    {
        emeraldsCount = 0;
        emeraldsMax = 0;

        foreach (GameObject gameObject in emeraldList)
        {
            int i = Random.Range(0, 10);
            if (i < 6)
            {
                gameObject.SetActive(true);
                emeraldsMax += 1;

            }

        }

    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        emeralds = collision.gameObject;
        if(emeralds.tag == "Emeralds")
        {
            emeraldsCount += 1;
            Destroy(emeralds);
        }
    }
}
