using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Data : MonoBehaviour
{
    [SerializeField] int flour;
    [SerializeField] int wheat;
    [SerializeField] int bread;

    [SerializeField] lvl[] lvls;

    int currentLvl;
    int currentLvlIndex = 0;

    public void setUpLvl(int lvl)
    {
        currentLvl = lvl;
        currentLvlIndex = 0;
    }

    public int getFlour()
    {
        return flour;
    }
    public int getWheat()
    {
        return wheat;
    }
    public int getBread()
    {
        return bread;
    }
    public void moreFlour(int quatity)
    {
        flour += quatity;
    }
    public void moreWheat(int quatity)
    {
        wheat += quatity;
    }
    public void moreBread(int quatity)
    {
        bread += quatity;
    }

    public int ProcessOfCurrentLvl()
    {
        return lvls[currentLvlIndex].processNumber;
    }

    public void updateProcessOfCurrentLvl(int process)
    {
        lvls[currentLvlIndex].processNumber = process;
    }
    public int goalNumberOfCurrentLvl()
    {
        return lvls[currentLvlIndex].goalNumber;
    }
}

[Serializable]
public struct lvl{
    [SerializeField] int LvlNumber;
    [SerializeField] public int goalNumber;
    [SerializeField] public int processNumber;
    [SerializeField] Phanthuong[] phanThuong;
}

[Serializable]
public struct Phanthuong
{
    [SerializeField] int type;
    [SerializeField] int so_lg;
}

