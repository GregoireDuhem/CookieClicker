using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Increment()
    {
        GameManager.cookies += GameManager.multiplier;
        PlayerPrefs.SetInt("cookies", GameManager.cookies);
    }

    public void Buy(int nb)
    {
        if (nb == 1 && GameManager.cookies >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.cookies -= 25;
            PlayerPrefs.SetInt("cookies", GameManager.cookies);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);

            
        }
        if (nb == 2 && GameManager.cookies >= 250)
        {
            GameManager.multiplier += 10;
            GameManager.cookies -= 250;
            PlayerPrefs.SetInt("cookies", GameManager.cookies);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (nb == 3 && GameManager.cookies >= 2500)
        {
            GameManager.multiplier += 100;
            GameManager.cookies -= 2500;
            PlayerPrefs.SetInt("cookies", GameManager.cookies);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
    }

    void Update()
    {
        ui.text = "Cookies: " + GameManager.cookies;
        // ui.text = "Multiplier " + GameManager.multiplier;
    }
}
