using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlComplete : MonoBehaviour
{
    [SerializeField] Controller ctrler;
    [SerializeField] Data data;

    public void clickClaim()
    {        
        data.moreFlour(2000);
        data.moreBread(2000);
        ctrler.TurnOnMenu(gameObject);
        Debug.Log("da luu vao data");
    }
}
