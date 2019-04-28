using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorNG : MonoBehaviour
{
    public static readonly int maxColor‬ = 16777215;
    public static readonly int minColor = 0;

    public static int GenerateRandomColor()
    {
        var retVal = Random.Range(minColor, maxColor);
        return retVal;
    }

    public static UnityEngine.Color CreateColor(byte r, byte g, byte b)
    {
        // The below code is for mixing colors before creation
        //r = (byte)(r * (r + 40) / 2);
        //g = (byte)((g + 10) / 2);
        //b = (byte)((b + 200) / 2);

        var retVar = new UnityEngine.Color(r / 255f, g / 255f, b / 255f);
        return retVar;
    }
}
