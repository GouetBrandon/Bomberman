using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{

    public ChangeScene changeScene;
    public GameObject gameMode;
    public Canvas winCanva;
    public TMP_Text winText;
    public Player player1;
    public Player2 player2;

    public Image player1HPSprite;
    public Sprite[] player1HPArray;
    public Image Player1MegaBombSprite;
    public Image Player1SpeedBoostSprite;

    public Image player2HPSprite;
    public Sprite[] player2HPArray;
    public Image Player2MegaBombSprite;
    public Image Player2SpeedBoostSprite;

    void Start()
    {
        player1HPSprite.sprite = player1HPArray[3];
        player2HPSprite.sprite = player2HPArray[3];
    }


    void Update()
    {

        if (gameMode.GetComponent<MultiplayerMode>().P1Win)
        {
            winCanva.enabled = true;
            winText.text = "Player 1 Wins !";
            StartCoroutine(EndOfGame());
        }

        else if (gameMode.GetComponent<MultiplayerMode>().P2Win)
        {
            winCanva.enabled = true;
            winText.text = "Player 2 Wins !";
            StartCoroutine(EndOfGame());
        }

        player1HPSprite.sprite = player1HPArray[player1.GetComponent<PlayerManager>().playerHP];
        player2HPSprite.sprite = player2HPArray[player2.GetComponent<PlayerManager>().playerHP];

        if (player1.hasMegaBomb)
        {
            Player1MegaBombSprite.enabled = true;
        }
        else if (!player1.hasMegaBomb)
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

        if (player2.hasMegaBomb)
        {
            Player2MegaBombSprite.enabled = true;
        }
        else if (!player2.hasMegaBomb)
        {
            Player2MegaBombSprite.enabled = false;
        }

        if (player2.hasSpeedBoost)
        {
            Player2SpeedBoostSprite.enabled = true;
        }
        else if (!player2.hasSpeedBoost)
        {
            Player2SpeedBoostSprite.enabled = false;
        }
    }

    public IEnumerator EndOfGame()
    {
        yield return new WaitForSeconds(3);
        changeScene.MoveToScene(0);

    }

    
}
