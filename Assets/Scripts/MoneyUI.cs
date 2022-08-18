using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    #region Singleton

    public static MoneyUI instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    #endregion

    [SerializeField] Text moneyAmount;

    public void UpdateMoneyAmount(int money)
    {
        moneyAmount.text = money.ToString();
    }
}
