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

    public static UnityEngine.Color CreateColor(int colorInteger)
    {
        colorInteger = (colorInteger > maxColor ? maxColor : colorInteger);

        var r = (byte)((colorInteger / 65536) % 256);
        var g = (byte)((colorInteger / 256) % 256);
        var b = (byte)(colorInteger % 256);

        var retVal = CreateColor(r, g, b);
        return retVal;
    }
    
    public static UnityEngine.Color CreateColor(byte r, byte g, byte b)
    {
        var retVar = new Color(r / 255f, g / 255f, b / 255f);
        return retVar;
    }

    public static UnityEngine.Color MixColor(UnityEngine.Color color, byte rMix, byte gMix, byte bMix)
    {
        color.r = (byte)(color.r * (color.r + rMix) / 2);
        color.g = (byte)((color.g + gMix) / 2);
        color.b = (byte)((color.b + bMix) / 2);

        return color;
    }

    public static UnityEngine.Color MixColor(UnityEngine.Color color, UnityEngine.Color colorMix)
    {
        color.r = (byte)(color.r * (color.r + colorMix.r) / 2);
        color.g = (byte)((color.g + colorMix.g) / 2);
        color.b = (byte)((color.b + colorMix.b) / 2);

        return color;
    }

}
