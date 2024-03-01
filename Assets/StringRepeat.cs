using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringRepeat : MonoBehaviour
{
    //Place script onto any game object (preferrably the camera) to activate the script
    [SerializeField] string message;
    [SerializeField] int count;
    // Start is called before the first frame update
    void Start()
    {
        counting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void counting()
    {
        for (int c = 0; c < count; c++)
        {
            Debug.Log(message);
        }
    }
}
