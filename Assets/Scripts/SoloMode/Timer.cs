using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public TMP_Text textTime;
    public float time;

    void Start()
    {
        
    }


    void Update()
    {
        time -= Time.deltaTime;
        textTime.text = "" + System.Math.Round(time);

        if(time <= 0)
        {
            time = 0;
        }
    }
}
