using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bomb : MonoBehaviour
{
    public GameObject bomb;
    public GameObject explosionMiddle;
    public GameObject explosionLeft;
    public GameObject explosionRight;
    public GameObject explosionUp;
    public GameObject explosionDown;


    void Start()
    {
        StartCoroutine(BombExplosion());
    }


    void Update()
    {
        
    }

    public IEnumerator BombExplosion()
    {
        yield return new WaitForSeconds(3f);
        Destroy(bomb);
        Instantiate(explosionMiddle, new Vector2(bomb.transform.position.x, bomb.transform.position.y), Quaternion.identity);
        Instantiate(explosionRight, new Vector2(bomb.transform.position.x + 1,bomb.transform.position.y), Quaternion.identity);
        Instantiate(explosionLeft, new Vector2(bomb.transform.position.x - 1, bomb.transform.position.y), Quaternion.identity);
        Instantiate(explosionUp, new Vector2(bomb.transform.position.x, bomb.transform.position.y + 1), Quaternion.identity);
        Instantiate(explosionDown, new Vector2(bomb.transform.position.x, bomb.transform.position.y - 1), Quaternion.identity);
        StopCoroutine(BombExplosion());
    }
}
