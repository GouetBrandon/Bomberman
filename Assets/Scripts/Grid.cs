using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    public List<GameObject> walls;

    void Start()
    {
        
        foreach (GameObject gameObject in walls)
        {
            int i = Random.Range(0, 10);
            if (i < 6)
            {
                gameObject.SetActive(true);
                
            }
            Debug.Log(i);
        }

    }


    void Update()
    {
        
    }
}
