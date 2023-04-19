using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bomb : MonoBehaviour
{
    public GameObject bomb;
    public GameObject megaBomb;
    public GameObject explosionMiddle;
    public GameObject explosionLeft;
    public GameObject explosionRight;
    public GameObject explosionUp;
    public GameObject explosionDown;
    public GameObject explosionHorizontal;
    public GameObject explosionVertical;

    [SerializeField]
    private bool isMegaBomb;


    void Start()
    {
        StartCoroutine(BombExplosion());
    }


    void Update()
    {
        
    }

    public IEnumerator BombExplosion()
    {
        if(isMegaBomb)
        {
            yield return new WaitForSeconds(3f);
            Destroy(megaBomb);
            Instantiate(explosionMiddle, new Vector2(megaBomb.transform.position.x, megaBomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionHorizontal, new Vector2(megaBomb.transform.position.x + 1, megaBomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionHorizontal, new Vector2(megaBomb.transform.position.x + 2, megaBomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionHorizontal, new Vector2(megaBomb.transform.position.x - 1, megaBomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionHorizontal, new Vector2(megaBomb.transform.position.x - 2, megaBomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionVertical, new Vector2(megaBomb.transform.position.x, megaBomb.transform.position.y + 1), Quaternion.identity);
            Instantiate(explosionVertical, new Vector2(megaBomb.transform.position.x, megaBomb.transform.position.y + 2), Quaternion.identity);
            Instantiate(explosionVertical, new Vector2(megaBomb.transform.position.x, megaBomb.transform.position.y - 1), Quaternion.identity);
            Instantiate(explosionVertical, new Vector2(megaBomb.transform.position.x, megaBomb.transform.position.y - 2), Quaternion.identity);
            Instantiate(explosionRight, new Vector2(megaBomb.transform.position.x + 3, megaBomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionLeft, new Vector2(megaBomb.transform.position.x - 3, megaBomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionUp, new Vector2(megaBomb.transform.position.x, megaBomb.transform.position.y + 3), Quaternion.identity);
            Instantiate(explosionDown, new Vector2(megaBomb.transform.position.x, megaBomb.transform.position.y - 3), Quaternion.identity);
        }
        else
        {
            yield return new WaitForSeconds(3f);
            Destroy(bomb);
            Instantiate(explosionMiddle, new Vector2(bomb.transform.position.x, bomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionRight, new Vector2(bomb.transform.position.x + 1, bomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionLeft, new Vector2(bomb.transform.position.x - 1, bomb.transform.position.y), Quaternion.identity);
            Instantiate(explosionUp, new Vector2(bomb.transform.position.x, bomb.transform.position.y + 1), Quaternion.identity);
            Instantiate(explosionDown, new Vector2(bomb.transform.position.x, bomb.transform.position.y - 1), Quaternion.identity);
        }
        
        StopCoroutine(BombExplosion());
    }
}
