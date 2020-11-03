using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirStrike : MonoBehaviour
{
    public Damage Player;
    public GameObject Smoke;

    public int strikeDamage = 50; 

    private float timeBtwFiring;
    public float startTimeBeforeFiring = 2;

    public Material Warning; //the material it changes to when the player walks over it
    public Material Deactive; //the original material

    Renderer shaperender;

    public Cloak AreCloaked; //if true stops the airstrike from firing

    // Start is called before the first frame update
    void Start()
    {
        shaperender = GetComponent<Renderer>();
        timeBtwFiring = startTimeBeforeFiring;
    }

    private void OnCollisionStay(Collision collision)
    {
        //when the player walks over the marker a timer will countdown and when it hits zero it will damage the player
        if (collision.collider.tag == "Player" && !AreCloaked.isCloaked)
        {
            shaperender.material = Warning; 
            if (timeBtwFiring <= 0)
            {
                Player.TakeDamage(strikeDamage);
                Instantiate(Smoke, transform.position + new Vector3(0,.1f,0), transform.rotation);
                timeBtwFiring = startTimeBeforeFiring + 2;
            }
            else
            {
                timeBtwFiring -= Time.deltaTime;
            }
        }
    }
    //when the player gets off the marker the timer resets and goes back to the original material
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            timeBtwFiring = startTimeBeforeFiring;
            shaperender.material = Deactive;
        }
    }


}
