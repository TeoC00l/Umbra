using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform hourTransform, minuteTransform, secondTransform;
    [SerializeField] private float degreesPerHour;
    [SerializeField] private float degreesPerMinute;
    [SerializeField] private float degreesPerSecond;
    [SerializeField] private bool continous;

    void Update()
    {
        if (continous)
        {
            UpdateContinously();
        }
        else
        {
            UpdateDiscrete();
        }
    }

    private void UpdateContinously()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hourTransform.localRotation = Quaternion.Euler(0f, (float) time.TotalHours * degreesPerHour, 0f);
        minuteTransform.localRotation = Quaternion.Euler(0f, (float) time.TotalMinutes * degreesPerMinute, 0f);
        secondTransform.localRotation = Quaternion.Euler(0f, (float) time.TotalSeconds * degreesPerSecond, 0f);
    }

    private void UpdateDiscrete()
    {
        DateTime time = DateTime.Now;
        hourTransform.localRotation = Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minuteTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Minute * degreesPerMinute, 0f);
        secondTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Second * degreesPerSecond, 0f);
    }
}
