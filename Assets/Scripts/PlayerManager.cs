using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int playerHP;
    public bool invincible;
    public SpriteRenderer playerSprite;
    
    void Start()
    {
        resetHP(3);
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Explosion explosion = collision.GetComponent<Explosion>();

        if (explosion != null)
        {
            if (!invincible)
            {
                DecreaseHP();
            }
            
        }
    }

    public void resetHP(int hp)
    {
        playerHP = hp;
    }

    public void DecreaseHP()
    {
        playerHP = playerHP - 1;
        if (playerHP < 0)
        {
            playerHP = 0;
        }
        StartCoroutine(InvincibleTime());
    }

    public IEnumerator InvincibleTime()
    {
        invincible = true;
        playerSprite.color = new Color(1, 0, 0);
        yield return new WaitForSeconds(0.5f);
        playerSprite.color = new Color(1, 1, 1);
        yield return new WaitForSeconds(0.5f);
        playerSprite.color = new Color(1, 0, 0);
        yield return new WaitForSeconds(0.5f);
        playerSprite.color = new Color(1, 1, 1);
        yield return new WaitForSeconds(0.5f);
        playerSprite.color = new Color(1, 0, 0);
        yield return new WaitForSeconds(0.5f);
        playerSprite.color = new Color(1, 1, 1);
        yield return new WaitForSeconds(0.5f);
        invincible = false;
        StopCoroutine(InvincibleTime());
    }
}
