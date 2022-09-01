using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    void Start()
    {
        Item.OnCollectedItem += CheckItem;
    }

    void CheckItem(Item item)
    {
        if (item.isMoney) return;

        ConditionUI.instance.UpdateCondition(item.conditionInpact);
    }

    private void OnDisable()
    {
        Item.OnCollectedItem -= CheckItem;
    }
}
