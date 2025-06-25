using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rate : MonoBehaviour
{
    public void clickGreat()
    {
        Debug.Log("This game is great!");
        gameObject.SetActive(false);
    }

    public void clickLater()
    {
        Debug.Log("ban chua danh gia cho Game");
        gameObject.SetActive(false);
    }
}
