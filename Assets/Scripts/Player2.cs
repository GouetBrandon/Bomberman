using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public InputManager inputManager;
    public Transform player2Transform;
    public Rigidbody2D rgbd;
    public Bomb bomb;
    public float speed = 0.1f;

    private bool player2Horizontal = false;
    private bool player2Vertical = false;
    private bool bombing2 = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            player2Vertical = true;
            if(!player2Horizontal)
            {
                rgbd.MovePosition(player2Transform.position + player2Transform.up * speed);
            }
            
        }


        if (Input.GetKey(KeyCode.DownArrow) == true)
        {

            player2Vertical = true;
            if(!player2Horizontal)
            {
                rgbd.MovePosition(player2Transform.position + player2Transform.up * -speed);
            }
            
        }

        if (Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            player2Vertical = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            player2Horizontal = true;
            if(!player2Vertical)
            {
                rgbd.MovePosition(player2Transform.position + player2Transform.right * -speed);
            }
            
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            player2Horizontal = true;
            if(!player2Vertical)
            {
                rgbd.MovePosition(player2Transform.position + player2Transform.right * speed);
            }
            
        }

        if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false)
        {
            player2Horizontal = false;
        }

        if (Input.GetKey(KeyCode.Keypad0) == true)
        {
            PlaceBomb2();
            
        }
    }

    void PlaceBomb2()
    {
        
        if (!bombing2)
        {
            bombing2 = true;
            Instantiate(bomb, player2Transform.position,Quaternion.identity);
            StartCoroutine(BombReset2());
        }
    }

    public IEnumerator BombReset2()
    {
        yield return new WaitForSeconds(2f);
        bombing2 = false;
        StopCoroutine(BombReset2());
    }
}
