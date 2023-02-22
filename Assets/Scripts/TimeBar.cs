using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
public class TimeBar : MonoBehaviour
{
    public GameObject bar;
    public float timeLOADS;
    public float timeBlack;
    public void AnimateBar()
    {
        LeanTween.scaleX(bar,0.95f, timeLOADS);
    }
    public void StopBar()
    {
        LeanTween.scaleX(bar, 0f,timeBlack);
    }
}
