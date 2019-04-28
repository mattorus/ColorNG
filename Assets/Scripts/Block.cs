using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] int colorInteger = ColorNG.maxColor;
    [SerializeField] Color32 color;
    [SerializeField] byte r = 100;
    [SerializeField] byte g = 100;
    [SerializeField] byte b = 100;
    [SerializeField] string colorHex = "0x646464";

    SpriteRenderer spriteRenderer;

    private void UpdateColor()
    {
        colorHex = System.Convert.ToString(colorInteger, toBase: 16);
        SetColor(ColorNG.CreateColor(r, g, b));
    }

    private void RandomizeColor()
    {
        colorInteger = ColorNG.GenerateRandomColor();
        // Move below code into ColorNG class
        b = (byte)(colorInteger % 256);
        g = (byte)((colorInteger / 256) % 256);
        r = (byte)((colorInteger / 65535) % 256);
    }

    //private UnityEngine.Color CreateColor(byte r, byte g, byte b)
    //{
    //    r = (byte)(r * (r + 40) / 2);
    //    g = (byte)((g + 10) / 2);
    //    b = (byte)((b + 200) / 2);

    //    var retVar = new UnityEngine.Color(r / 255f, g / 255f, b / 255f);
    //    return retVar; 
    //}

    private void SetColor(UnityEngine.Color color)
    {
        spriteRenderer.color = color;
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.color = color;
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RandomizeColor();
            UpdateColor();
        }
    }
}
