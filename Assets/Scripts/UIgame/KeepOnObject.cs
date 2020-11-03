using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepOnObject : MonoBehaviour
{
    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        //keep an object that the shield is circling on the player
        transform.position = Player.position;
    }
}
