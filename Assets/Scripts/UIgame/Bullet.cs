using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 3;
    public float lifeTime = 10;

    // Update is called once per frame
    void Update()
    {
        //moves the bullet forward until its lifetime is up
        transform.position += transform.forward * speed * Time.deltaTime;
        if(lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if(lifeTime <= 0)
            {
                Destroy(gameObject);
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision) //destroys on collision
    {
         Destroy(gameObject);
    }
}
