using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrePlay : MonoBehaviour
{
    [SerializeField] Controller ctrler;
    [SerializeField] Data data;
    [SerializeField] Slider slider;
    [SerializeField] Text slideText, slideGoalText;

    private void OnEnable()
    {
        float process = data.ProcessOfCurrentLvl();
        float goal = data.goalNumberOfCurrentLvl();
        slider.maxValue = goal;
        slider.value = process;
        slideText.text = ctrler.KNumber(process);
        slideGoalText.text = ctrler.KNumber(goal);
    }

    public void clickPlay()
    {
        ctrler.TurnOnGamePlay(gameObject);
    }
}
