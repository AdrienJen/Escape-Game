using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material[] materials;
    public Renderer rend;

    private int index=1;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (materials.Length == 0)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            index = 2;
            rend.sharedMaterial = materials[index - 1];
        }
    }

    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            index = 1;
            rend.sharedMaterial = materials[index - 1];
        }
    }
}
