using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject Player; //the object that stays on the player
    //timer for how long the shield is frozen
    private float timeBtwSpawnFrozen;
    public float startTimeBtwSpawnFrozen = 5;

    public bool FreezePos = false; // if the shield is frozen
    public float speed = 20; //how fast the shield is going around the player

    // Update is called once per frame
    void Update()
    {
        if(!FreezePos)
        {
            transform.RotateAround(Player.transform.position, Vector3.up, speed * Time.deltaTime);
        }
        else
        {
            if (timeBtwSpawnFrozen <= 0)
            {
                FreezePos = false;
            }
            else
            {
                timeBtwSpawnFrozen -= Time.deltaTime;
            }
        }
    }

    public void FreezeShield()
    {
        FreezePos = true;
        timeBtwSpawnFrozen = startTimeBtwSpawnFrozen;
    }
}
