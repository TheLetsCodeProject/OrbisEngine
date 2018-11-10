using System;
using UnityEngine;

namespace OrbisEngine.Utility
{
    // VITAL: Not finished at all
    public class Timer
    {
        public static string DefaultMinuteFormatting = "00";
        public static string DefaultSecondFormatting = "00.00";

        // state monitoring
        float m_StartTime;
        float m_EndTime;
        float m_TotalTime;

        bool m_Started = false;
        public bool IsStarted { get { return m_Started; } }

        public void Start(float elapsedTime = 0f)
        {
            if (m_Started)
                Debug.LogWarning("Timer is already started. This resets the timer");

            m_StartTime = Time.time;
            m_Started = true;
        }

        public void Stop()
        {
            if (m_Started == false)
                Debug.Log("Timer is not started");

            m_EndTime = Time.time;
            m_Started = false;
        }
    }
}