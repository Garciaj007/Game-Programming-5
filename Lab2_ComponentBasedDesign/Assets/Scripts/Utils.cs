﻿using UnityEngine;
public static class Utils
{
    public static class TimeFormat
    {
        public static string FormatTime(float time)
        {
            int minutes = (int)time / 60;
            int seconds = (int)time - 60 * minutes;
            int millis = (int)(1000 * (time - minutes * 60 - seconds));
            return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, millis);
        }
    }

    public static class Rigidbody2D
    {
        public static float Heading(Vector3 velocity)
        {
            return Vector3.Dot(Vector3.forward, velocity);
        }
    }

    public static class Mathf
    {
        public static float Map(float value, float inMin, float inMax, float outMin, float outMax)
        {
            return (value - inMin) / (inMax - inMin) * (outMax - outMin) + outMin;
        }
    }
}
