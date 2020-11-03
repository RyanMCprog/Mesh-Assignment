using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject turretBullet;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn = 5;

    // Update is called once per frame
    void Update()
    {
        //spawns bullets as along as it is not frozen
        if (TurretManager.Instance.frozen == false)
        {
            if (timeBtwSpawn <= 0)
            {
                Instantiate(turretBullet, transform.position, transform.rotation);
                timeBtwSpawn = startTimeBtwSpawn;
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;
            }
        }
    }

    
}
