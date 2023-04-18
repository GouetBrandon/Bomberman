using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableWall : MonoBehaviour
{
    public DestroyableWall destroyableWall;
    public GameObject tile;
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Explosion destroyable = collision.GetComponent<Explosion>();
        if (destroyable != null)
        {
            Debug.Log("coucou");
            Destroy(tile);
        }
    }
}
