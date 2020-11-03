using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Portal : MonoBehaviour
{
    // components needed for in-game changes when the player enters the portal
    public Bullet BulletSpeed;
    public Damage StrongerShot;
    public GameObject Player;
    public TurretManager FrozenTime;

    //left portal change
    public int changedDamage = 5;
    public float changedSpeed = 1;
    //right portal change
    public float changedFrozenTime = 1;

    private Quaternion target;
    public float smooth = 5f;
    public bool isLeftPortal;

    //spawn shortcut bridge when going through center portal
    public bool IsCenterPortal = false;
    public GameObject Shortcut;
    public GameObject CenterTurret;
    public GameObject TurretVolley;
    public GameObject SecondTurentVolley;


    // Start is called before the first frame update
    void Start()
    {
        target = Quaternion.Euler(0, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            //when going thourgh any portal it will move the player back to start and heal the player back to full
            Player.transform.position = new Vector3(0, 1, 0);
            Player.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
            StrongerShot.heal();
            //if it is the left portal change turrets
            if(isLeftPortal)
            {
                BulletSpeed.speed += changedSpeed;
                StrongerShot.inflictedDamage += changedDamage;

                FrozenTime.AddScore();
            }
            else if(IsCenterPortal) //entering the Center portal causes the shortcut bridge and the turrets on the shortcut to appear
            {
                Shortcut.SetActive(true);
                CenterTurret.SetActive(false);
                TurretVolley.SetActive(true);
                SecondTurentVolley.SetActive(true);
            }
            else //if entering the right change player 
            {
                if(FrozenTime.startTimeBtwSpawnFrozen > 0)
                {
                    FrozenTime.startTimeBtwSpawnFrozen -= changedFrozenTime;
                }

                FrozenTime.AddScore();
            }

            
            //add score for each run thourgh the portal
        }
    }
}
