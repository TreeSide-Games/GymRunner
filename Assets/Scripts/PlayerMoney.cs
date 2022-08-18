using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    int money;

    void Start()
    {
        Item.OnCollectedItem += CheckItem;
        money = PlayerPrefs.GetInt("PlayerMoney");

        MoneyUI.instance.UpdateMoneyAmount(money);
    }

    private void CheckItem(Item item)
    {
        if (item.isMoney)
        {
            money += 3;
            MoneyUI.instance.UpdateMoneyAmount(money);
            PlayerPrefs.SetInt("PlayerMoney", money);
        }
    }
}
