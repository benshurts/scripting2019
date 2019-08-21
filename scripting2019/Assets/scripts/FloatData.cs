﻿using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;

    public void UpdateValue(float number)
    {
        value += number;
    }
}
