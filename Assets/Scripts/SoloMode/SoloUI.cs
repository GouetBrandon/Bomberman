using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoloUI : MonoBehaviour
{
    public Player player1;

    public Image player1HPSprite;
    public Sprite[] player1HPArray;
    public Image Player1MegaBombSprite;
    public Image Player1SpeedBoostSprite;

    public Emeralds emerald;
    public TMP_Text emeraldsText;
    public TMP_Text emeraldsMaxText;


    void Start()
    {
        player1HPSprite.sprite = player1HPArray[3];

    }


    void Update()
    {

        emeraldsText.text = player1.GetComponent<Emeralds>().emeraldsCount.ToString();
        emeraldsMaxText.text ="/" + player1.GetComponent<Emeralds>().emeraldsMax.ToString();

        player1HPSprite.sprite = player1HPArray[player1.GetComponent<PlayerManager>().playerHP];

        if(player1.hasMegaBomb)
        {
            Player1MegaBombSprite.enabled = true;
        }
        else if(!player1.hasMegaBomb)
        {
            Player1MegaBombSprite.enabled = false;
        }

        if (player1.hasSpeedBoost)
        {
            Player1SpeedBoostSprite.enabled = true;
        }
        else if (!player1.hasSpeedBoost)
        {
            Player1SpeedBoostSprite.enabled = false;
        }
    }
}
