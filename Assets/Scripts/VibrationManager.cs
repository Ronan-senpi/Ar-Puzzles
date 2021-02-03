using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationManager : MonoBehaviour
{
    bool vibrate = false;
    float vibrateDelay = 5;
    float passedTime = 0;
    float VibrationDuration { get; set; } = 0;
    public void ToggleVibrate()
    {
        vibrate = !vibrate;
        Debug.Log("vibrate : " + vibrate);
    }
    public void SetVibrationInterval(float value)
    {
        vibrateDelay = value;
        Debug.Log("vibrateDelay : " + vibrateDelay);
    }

    public float GetVibrateDelay()
    {
        return vibrateDelay;
    }

    private void Update()
    {
        if (vibrate)
        {
            if (passedTime >= vibrateDelay)
            {
                Handheld.Vibrate();
                if (VibrationDuration != 0)
                {
                    StartCoroutine(ResetTime());
                }
                else
                {
                    passedTime = 0;
                }
                Debug.Log("Bzzzz : " + passedTime);
            }
            else
            {
                passedTime += Time.deltaTime;
            }

        }
    }
    IEnumerator ResetTime()
    {
        yield return new WaitForSeconds(VibrationDuration);
        passedTime = 0;
    }
}
