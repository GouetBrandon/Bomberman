using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoloUI : MonoBehaviour
{
    public ChangeScene changeScene;
    public GameObject gameMode;
    public Player player1;
    public Canvas winCanva;
    public TMP_Text winText;

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
        if (gameMode.GetComponent<SoloGamemode>().P1Win)
        {
            winCanva.enabled = true;
            winText.text = "You Won !";
            StartCoroutine(EndOfGame());
        }

        else if (gameMode.GetComponent<SoloGamemode>().gameOver)
        {
            winCanva.enabled = true;
            winText.text = "You loose !";
            StartCoroutine(EndOfGame());
        }

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
    public IEnumerator EndOfGame()
    {
        yield return new WaitForSeconds(3f);
        changeScene.MoveToScene(0);
    }
}
