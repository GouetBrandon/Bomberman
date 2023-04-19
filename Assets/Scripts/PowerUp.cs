using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject player;
    

    void Start()
    {

    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject;
        if(player != null && player.tag == "Player")
        {
            if(player.name == "Player")
            {
                if(gameObject.tag == "MegaBomb" && player.GetComponent<Player>().hasMegaBomb == false)
                {
                    player.GetComponent<Player>().hasMegaBomb = true;
                    Destroy(gameObject);
                }
                else if(gameObject.tag == "SpeedBoost" && player.GetComponent<Player>().hasSpeedBoost == false)
                {
                    player.GetComponent<Player>().hasSpeedBoost = true;
                    Destroy(gameObject);
                }
                
            }
            else
            {
                if(gameObject.tag == "MegaBomb" && player.GetComponent<Player2>().hasMegaBomb == false)
                {
                    player.GetComponent<Player2>().hasMegaBomb = true;
                    Destroy(gameObject);
                }
                else if (gameObject.tag == "SpeedBoost" && player.GetComponent<Player2>().hasSpeedBoost == false)
                {
                    player.GetComponent<Player2>().hasSpeedBoost = true;
                    Destroy(gameObject);
                }
                
            }
            
        }
    }
}
