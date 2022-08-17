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
    }

    private void CheckItem(Item item)
    {
        if (item.isMoney)
        {
            money += 3;
            MoneyUI.instance.UpdateMoneyAmount(money);
        }
    }
}
