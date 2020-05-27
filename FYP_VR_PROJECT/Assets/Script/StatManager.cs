using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    public float Score = 0;
    public float Time = 120;
    public TMPro.TextMeshPro scoreTxt;
    public TMPro.TextMeshPro timeTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeTxt.text = ("Time Remaining: " + Mathf.FloorToInt(Time) + "s");
        scoreTxt.text = ("Score: " + Score);
    }
}
