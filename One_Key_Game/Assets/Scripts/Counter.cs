using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int counter;
    public Text counterText;

    void Start()
    {
        
    }

    void Update()
    {
        counterText.text = counter.ToString();
    }

    public void AddScore()
    {
        counter++;
    }
}
