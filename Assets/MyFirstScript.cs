using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [SerializeField]
    private int frameNum;
    // Start is called before the first frame update
    void Start()
    {
        frameNum = 1;
        Debug.Log("I was told to start: "+gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("frame #{0}: Update at Time {1}", frameNum, Time.time);
        Debug.Log("Frame" +frameNum + "Update at Time" + Time.time); 
        frameNum= frameNum + 1;
    }
}
