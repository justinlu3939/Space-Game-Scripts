using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public float time = 20f;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = "Time Remaining: " + Mathf.FloorToInt(time).ToString();
    }
}
