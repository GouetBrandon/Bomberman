using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    public GameObject prefab;

    void Start()
    {
        
        for (int x = 0; x < 50; x++)
        {
            for (int y = 0; y < 50; y++)
            {
                int j = Random.Range(0, 4);
                if (j == 2)
                {
                    //Instantiate(prefab, new Vector2(x, y));
                }
            }
           
        }

    }


    void Update()
    {
        
    }
}
