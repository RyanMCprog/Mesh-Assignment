using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCooldown : MonoBehaviour
{
    private Button button;

    private float timeBtwCooldown;
    public float startTimeBtwCooldown = 5;

    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the button is on cooldown start the countdown then when it hits zero activate the button again
        if(timeBtwCooldown > 0)
        {
            timeBtwCooldown -= Time.deltaTime;
        }
        else if(button.interactable == false)
        {
            button.interactable = true;
        }
    }

    public void OnCooldown() //puts button on cooldown when the button is clicked
    {
        button.interactable = false;
        timeBtwCooldown = startTimeBtwCooldown;
    }
}
