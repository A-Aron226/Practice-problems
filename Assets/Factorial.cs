using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factorial : MonoBehaviour
{
    //Place script onto any game object (preferrably the camera) to activate the script
    [SerializeField] int number;
    int n;
    // Start is called before the first frame update
    void Start()
    {
        factorial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void factorial()
    {
        n = number;
        for (int i = number - 1; i >= 1; i--)
        {
            n = n * i;
        }

        Debug.Log(n);
    }
}
