using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    Item conditionItem;
    void Start()
    {
        Item.OnCollectedItem += CheckItem;
    }

    void CheckItem(Item item)
    {
        if (item.isMoney) return;

        if (item.isHealthy)
            ConditionUI.instance.UpdateCondition(10);
        else
            ConditionUI.instance.UpdateCondition(-10);
    }
}
