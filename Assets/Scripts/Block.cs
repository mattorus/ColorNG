using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] int colorInteger;
    [SerializeField] string colorHex;

    SpriteRenderer spriteRenderer;

    private void UpdateColor()
    {
        colorHex = System.Convert.ToString(colorInteger, toBase: 16);
        SetColor(ColorNG.CreateColor(colorInteger));
    }

    private void RandomizeColor()
    {
        colorInteger = ColorNG.GenerateRandomColor();
    }

    private void SetColor(UnityEngine.Color color)
    {
        spriteRenderer.color = color;
    }

    // Start is called before the first frame update
    void Start()
    {
        colorInteger = ColorNG.maxColor;
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
