using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConditionUI : MonoBehaviour
{
    #region Singleton
    public static ConditionUI instance;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    #endregion


    [SerializeField] Slider conditionSlider;

    public static event Action OnConditionEnd;

    void Start()
    {
        conditionSlider.value = conditionSlider.maxValue;

        StartCoroutine(UpdateCoroutine());
    }

    IEnumerator UpdateCoroutine()
    {
        while (conditionSlider.value > 0)
        {
            UpdateCondition(-0.5f);

            yield return new WaitForSeconds(0.1f);
        }

        //OnConditionEnd.Invoke();
    }

    public void UpdateCondition(float value)
    {
        conditionSlider.value += value;

        if (conditionSlider.value <= 0)
            OnConditionEnd.Invoke();
            //SceneChanger.instance.DisplayMenu();
    }
}
