using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoloGamemode : MonoBehaviour
{

    public Player player1;
    public Emeralds emeralds;
    public Timer time;

    public bool gameOver;
    public bool P1Win = false;

    void Start()
    {
        
    }


    void Update()
    {
        if (player1.GetComponent<PlayerManager>().playerHP == 0 || time.time == 0)
        {
            gameOver = true;
            
        }

        else if(player1.GetComponent<Emeralds>().emeraldsCount == player1.GetComponent<Emeralds>().emeraldsMax)
        {
            gameOver = true;
            P1Win = true;
        }
    }

    
}
