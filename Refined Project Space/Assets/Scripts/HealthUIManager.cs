using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIManager : MonoBehaviour
{
    public Text healthText, livesText;

    public int health, lives;

    public static HealthUIManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        healthText.text = health.ToString();
        livesText.text = lives.ToString();
    }

    public void removeHealth()
    {
        health--;
        healthText.text = health.ToString();
    }

    public void removeLives()
    {
        lives--;
        livesText.text = lives.ToString();
    }

}
