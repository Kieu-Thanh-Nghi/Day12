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

    public void clickCollect(int type)
    {
        switch (type)
        {
            case 1:
                data.moreFlour(textToInt(textFlour));
                Debug.Log("Da nhap vao data");
                break;
            case 2:
                data.moreWheat(textToInt(textWheat));
                Debug.Log("Da nhap vao data");
                break;
            case 3:
                data.moreBread(textToInt(textBread));
                Debug.Log("Da nhap vao data");
                break;
        }
    }

    public void clickOut()
    {
        ctrler.TurnOnMenu(gameObject);
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
