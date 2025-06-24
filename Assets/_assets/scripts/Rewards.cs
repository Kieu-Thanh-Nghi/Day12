using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rewards : MonoBehaviour
{
    [SerializeField] Sprite disableButton;
    [SerializeField] Text textFlour, textWheat, textBread;
    [SerializeField] Controller ctrler;
    [SerializeField] Data data;
    int clickTimes = 0;

    public void clickCollect()
    {
        if(clickTimes == 2)
        {
            ctrler.TurnOnMenu(gameObject);
            data.moreBread(textToInt(textBread));
            data.moreFlour(textToInt(textFlour));
            data.moreWheat(textToInt(textWheat));
            Debug.Log("Da nhap vao data");
        }
        clickTimes++;
    }

    int textToInt(Text t)
    {
        string str = t.text;
        if (str.EndsWith("K"))
        {
            return int.Parse(str.Remove(str.Length - 1))*1000;
        }
        return int.Parse(str);
    }
}
