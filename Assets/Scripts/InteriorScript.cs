using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorScript : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mats;

    public void ChangeColor(int colorIndex)
    {
        foreach (Renderer mat in mats)
        {
            mat.material.color = colors[colorIndex];
        }
    }
}
