using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    
    public void setMaxHealth(int health)
    {
        //resets health meter
        slider.maxValue = health;
        slider.value = health;
    }

    public void setHealth(int health)
    {
        //displays current health
        slider.value = health;
    }
}
