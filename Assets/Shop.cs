using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int money = 100;
    public Text moneyText;

    public void buyItem(string item)
    {
        moneyText.text = money.ToString();
    }
}
