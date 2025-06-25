using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Text processText;
    [SerializeField] Controller ctrl;

    
    public void updateProcessValue()
    {
        processText.text = ctrl.KNumber((int)slider.value);
    }

    public void ClickDone()
    {
        if(slider.value < 2000)
        {
            ctrl.TurnOnMenu(gameObject);
        }
        else
        {
            ctrl.TurnOnLvlComplete(gameObject);
        }
    }

    public void ClickPause()
    {
        ctrl.TurnOnPause();
    }
}
