using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationImplementation : Vibration
{
    bool vibrate = false;
    float passedTime = 0;
    public void VibPlus()
    {
        vibrate = true;
    }

    private void Update()
    {
        if (vibrate)
        {
            Handheld.Vibrate();
        }   
    }
}
