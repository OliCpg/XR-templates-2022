using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("I'm in it (" + counter +")" );
        counter++;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("I'm out");
    }
}
