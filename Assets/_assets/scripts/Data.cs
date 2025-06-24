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
}

[Serializable]
public struct lvl{
    [SerializeField] int LvlNumber;
    [SerializeField] int goalNumber;
    [SerializeField] int processNumber;
}

