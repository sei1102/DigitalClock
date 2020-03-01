using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;


public class TimeNowScript : MonoBehaviour
{
    private TextMeshPro ClockText;

    // Use this for initialization
    void Start()
    {
        ClockText = this.GetComponent<TextMeshPro>();
        ClockText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        ClockText.text = DateTime.Now.ToLongTimeString();
    }
}
