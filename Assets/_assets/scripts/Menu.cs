using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] Data data;
    [SerializeField] Text flourNumber, wheatNumber, breadNumber;
    [SerializeField] Controller ctrler;
    private void OnEnable()
    {
        flourNumber.text = data.getFlour().ToString();
        wheatNumber.text = data.getWheat().ToString();
        breadNumber.text = data.getBread().ToString();
    }
    public void clkPlay()
    {
        ctrler.TurnOnPrePlay(gameObject);
    }
    public void clkRate()
    {
        ctrler.TurnOnRate(gameObject);
    }
    public void clkDailyRewards()
    {
        ctrler.TurnOnRewards(gameObject);
    }
}
