using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerMode : MonoBehaviour
{

    public Player player1;
    public Player2 player2;

    public bool gameOver;
    public bool P1Win = false;
    public bool P2Win = false;

    void Start()
    {
        
        
    }


    void Update()
    {
        if(player1.GetComponent<PlayerManager>().playerHP == 0)
        {
            gameOver = true;
            P2Win = true;
        }

        else if(player2.GetComponent<PlayerManager>().playerHP == 0)
        {
            gameOver = true;
            P1Win = true;
        }
    }
}
