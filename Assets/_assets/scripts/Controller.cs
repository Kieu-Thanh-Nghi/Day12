using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] Rewards rewards;
    [SerializeField] lvlComplete lvl_complete;
    [SerializeField] PrePlay prePlay;
    [SerializeField] Rate rate;
    [SerializeField] Pause pause;
    [SerializeField] Menu menu;
    [SerializeField] GamePlay gameplay;
    public void TurnOnRewards(GameObject current)
    {
        rewards.gameObject.SetActive(true);
        current.SetActive(false);
    }
    public void TurnOnLvlComplete(GameObject current)
    {
        lvl_complete.gameObject.SetActive(true);
        current.SetActive(false);
    }
    public void TurnOnPrePlay(GameObject current)
    {
        prePlay.gameObject.SetActive(true);
        current.SetActive(false);
    }
    public void TurnOnRate(GameObject current)
    {
        rate.gameObject.SetActive(true);
        current.SetActive(false);
    }
    public void TurnOnPause(GameObject current)
    {
        pause.gameObject.SetActive(true);
        current.SetActive(false);
    }
    public void TurnOnMenu(GameObject current, bool isGamePlayOff = false)
    {
        if (isGamePlayOff)
        {
            gameplay.gameObject.SetActive(false);
        }
        current.SetActive(false);
        menu.gameObject.SetActive(true);
    }
    public void TurnOnGamePlay(GameObject current)
    {
        gameplay.gameObject.SetActive(true);
        current.SetActive(false);
    }
}
