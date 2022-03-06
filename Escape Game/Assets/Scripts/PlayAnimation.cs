using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator anim;

    public GameObject blue;
    public GameObject green;
    public GameObject red;
    public GameObject yellow;
    public GameObject blueClickable;
    public GameObject greenClickable;
    public GameObject redClickable;
    public GameObject yellowClickable;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        blue.SetActive(false);
        green.SetActive(false);
        red.SetActive(false);
        yellow.SetActive(false);
        blueClickable.SetActive(true);
        greenClickable.SetActive(true);
        redClickable.SetActive(true);
        yellowClickable.SetActive(true);
    }

    // Update is called once per frame
    
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            blue.SetActive(true);
            green.SetActive(true);
            red.SetActive(true);
            yellow.SetActive(true);
            blueClickable.SetActive(false);
            greenClickable.SetActive(false);
            redClickable.SetActive(false);
            yellowClickable.SetActive(false);
            anim.Play("Simon");
            StartCoroutine(WaitAnimation());
        }
    }

    

    IEnumerator WaitAnimation()
    {
        yield return new WaitForSeconds(8);
        blue.SetActive(false);
        green.SetActive(false);
        red.SetActive(false);
        yellow.SetActive(false);
        blueClickable.SetActive(true);
        greenClickable.SetActive(true);
        redClickable.SetActive(true);
        yellowClickable.SetActive(true);
    }
}
