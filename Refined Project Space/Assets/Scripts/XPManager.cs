using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPManager : MonoBehaviour
{
    public Text currentXPtext, targetXPtext, levelText;
    public int currentXP, targetXP, level;

    public static XPManager instance;

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
        currentXPtext.text = currentXP.ToString();
        targetXPtext.text = targetXP.ToString();
        levelText.text = level.ToString();
    }

    public void AddXP(int xp)
    {
        currentXP += xp;

        //level up while safeguards if it level up 2x or more with one xp gain 
        while(currentXP >= targetXP)
        {
            currentXP = currentXP - targetXP;
            level++;
            //increases TXP by 20%
            targetXP += targetXP / 20;


            levelText.text = level.ToString();
            targetXPtext.text = targetXP.ToString();

        }

        currentXPtext.text = currentXP.ToString();
    }

}
