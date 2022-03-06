using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCode : MonoBehaviour
{
    public string code = "";
    public GameObject showCode;
    public int numberTry = 0;
    void Start()
    {
        showCode.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (numberTry >= 9)
        {
            numberTry = 0;
            code = "";
        }
        if (code == "byrg")
        {
            showCode.SetActive(true);
        }
        
    }
}
