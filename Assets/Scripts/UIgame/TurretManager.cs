using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurretManager : MonoBehaviour
{
    //This is a game Manager more than a turret manager
    public static TurretManager Instance { get; private set; }
    //freezing the turrets
    public bool frozen = false;
    private float timeBtwSpawnFrozen;
    public float startTimeBtwSpawnFrozen = 5;

    //score
    public float Score = 0;
    public Text scoreText;

    //Change bullet speed back to its deflaut value when restarting
    public Bullet BulletSpeed;
    public float deflautSpeed = 3;

    //spawn bridge and particle effects for bridge portal
    public GameObject bridge;
    public GameObject Particles;

    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        BulletSpeed.speed = deflautSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //the timer for how long the turrets are frozen
        if(frozen)
        {
            if (timeBtwSpawnFrozen <= 0)
            {
                frozen = false;
            }
            else
            {
                timeBtwSpawnFrozen -= Time.deltaTime;
            }
        }
    }
   
    public void BecomeFrozen() //called when the freeze turret button is pressed
    {
        frozen = true;
        timeBtwSpawnFrozen = startTimeBtwSpawnFrozen;
    }

    public void AddScore() //adds one to the player's score
    {
        Score++;
        scoreText.text = Score.ToString();
        ScoreGoals();
    }

    public void OnFadeComplete() //when the fadeout animation completes
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ScoreGoals() //unlocks the shortcut portal when a score of 3 is hit
    {
        if(Score >= 3)
        {
            bridge.SetActive(true);
            Particles.SetActive(true);
        }
    }
}
