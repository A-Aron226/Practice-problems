using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseWord : MonoBehaviour
{
    //Place script onto any game object (preferrably the camera) to activate the script
    [SerializeField] string words;
    // Start is called before the first frame update
    void Start()
    {
        wordReverse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void wordReverse()
    {
        string[] word = words.Split(' ');
        string empty = " ";

        for (int w = word.Length - 1; w >= 0; w--)
        {
            empty += word[w]; //Reverses word

            if (w > 0)
            {
                empty += " "; //Seperates words through space
            }
        }

        Debug.Log(empty);
    }
}
