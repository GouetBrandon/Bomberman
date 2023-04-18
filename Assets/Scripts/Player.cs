using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public InputManager inputManager;
    public Transform playerTransform;
    public Rigidbody2D rgbd;
    public Bomb bomb;
    public float speed = 0.1f;

    private bool playerHorizontal = false;
    private bool playerVertical = false;
    private bool bombing = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.Z) == true)
        {
            playerVertical = true;
            if(!playerHorizontal)
            {
                rgbd.MovePosition(playerTransform.position + playerTransform.up * speed);
            }
            
        }


        if (Input.GetKey(KeyCode.S) == true)
        {

            playerVertical = true;
            if(!playerHorizontal)
            {
                rgbd.MovePosition(playerTransform.position + playerTransform.up * -speed);
            }
            
        }

        if (Input.GetKey(KeyCode.Z) == false && Input.GetKey(KeyCode.S) == false)
        {
            playerVertical = false;
        }

        if (Input.GetKey(KeyCode.Q) == true)
        {
            playerHorizontal = true;
            if(!playerVertical)
            {
                rgbd.MovePosition(playerTransform.position + playerTransform.right * -speed);
            }
            
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            playerHorizontal = true;
            if(!playerVertical)
            {
                rgbd.MovePosition(playerTransform.position + playerTransform.right * speed);
            }
            
        }

        if (Input.GetKey(KeyCode.Q) == false && Input.GetKey(KeyCode.D) == false)
        {
            playerHorizontal = false;
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            PlaceBomb();
            
        }
    }

    void PlaceBomb()
    {
        
        if (!bombing)
        {
            bombing = true;
            Instantiate(bomb, playerTransform.position,Quaternion.identity);
            StartCoroutine(BombReset());
        }
    }

    public IEnumerator BombReset()
    {
        yield return new WaitForSeconds(2f);
        bombing = false;
        StopCoroutine(BombReset());
    }
}
