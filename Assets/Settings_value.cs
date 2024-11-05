using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;


[CreateAssetMenu]
public class Settings_value : ScriptableObject
{
    [SerializeField]private float volume = 1;
    public bool HDR;
    public int graphics = 0; // High - 0, Medium - 1, Low - 2

    public void Volume_get_value(Slider slider)
    {
        volume = slider.value;
        Debug.Log(volume);
    }

    public void Graphics_get_value(TMP_Dropdown dropdown)
    {
        graphics = dropdown.value;
        Debug.Log(graphics);
    }

    public void HDR_get_value(Toggle toggle) { 
        HDR = toggle.isOn;
        Debug.Log(HDR);
    }

    public void Volume_set_value(Slider slider)
    {
        slider.value = volume;
        Debug.Log(volume);
    }
    public void Graphics_set_value(TMP_Dropdown dropdown)
    {
        dropdown.value = graphics;
        Debug.Log(graphics);
    }

    public void HDR_set_value(Toggle toggle)
    {
        toggle.isOn = HDR;
        Debug.Log(HDR);
    }
}
