using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Text processText;
    [SerializeField] Controller ctrl;
    [SerializeField] Data data;

    private void OnEnable()
    {
        processText.text = ctrl.KNumber(data.ProcessOfCurrentLvl());
        slider.value = data.ProcessOfCurrentLvl();
    }
    public void updateProcessValue()
    {
        processText.text = ctrl.KNumber((int)slider.value);
    }

    public void ClickDone()
    {
        if(slider.value < 2000)
        {
            ctrl.TurnOnMenu(gameObject);
            data.updateProcessOfCurrentLvl((int)slider.value);
        }
        else
        {
            ctrl.TurnOnLvlComplete(gameObject);
            data.updateProcessOfCurrentLvl((int)slider.value);
        }
    }

    public void ClickPause()
    {
        ctrl.TurnOnPause();
    }
}
