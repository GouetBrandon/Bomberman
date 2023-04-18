using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    void Start()
    {
        StartCoroutine(ExplosionVFX());
    }

    void Update()
    {
        
    }

    

    public IEnumerator ExplosionVFX()
    {
        yield return new WaitForSeconds(1f);
        Destroy(explosion);
        StopCoroutine(ExplosionVFX());
    }
}
