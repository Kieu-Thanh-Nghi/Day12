using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] Controller ctrler;
    public void clickSettings()
    {
        Debug.Log("chua co");
    }
    public void clickResume()
    {
        gameObject.SetActive(false);
    }
    public void clickManu()
    {
        ctrler.TurnOnMenu(gameObject, true);
    }
}
