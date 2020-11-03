using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloak : MonoBehaviour
{
    public Material cloaked;
    public Material unCloaked;
    Renderer Playerrender;

    public bool isCloaked = false;

    private float timeCloaked;
    public float startTimeCloaked = 3;
    // Start is called before the first frame update
    void Start()
    {
        Playerrender = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //cloak timer
        if(isCloaked)
        {
            if (timeCloaked <= 0)
            {
                isCloaked = false;
                Playerrender.material = unCloaked;
            }
            else
            {
                timeCloaked -= Time.deltaTime;
            }
        }
    }
    //when the button is clicked the player changes material and the timer for the cloak begins
    public void becomeCloaked()
    {
        Playerrender.material = cloaked;
        timeCloaked = startTimeCloaked;
        isCloaked = true;
    }
}
