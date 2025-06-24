using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardButtons : MonoBehaviour
{
    [SerializeField] Sprite buttonOn;
    private void OnDisable()
    {
        GetComponent<Image>().sprite = buttonOn;
        GetComponent<Button>().interactable = true;
    }
}
