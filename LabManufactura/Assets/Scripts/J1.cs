using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class J1 : MonoBehaviour
{
    public float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    public void GoToMainScene()
    {
        /* float t = Time.time - startTime;
        float seconds = (t % 60);
        if (seconds > 0.01)
        {
            RobotControl_UR5e.robotJ1SliderValue = 10.0F;
        } */
        for (int i = 0; i < 1000; i++)
        {
            RobotControl_UR5e.robotJ1SliderValue = 10.0F;

        }
        RobotControl_UR5e.robotJ1SliderValue = 0F;

    }
}
