using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ReverseLetter : MonoBehaviour
{
    //Place script onto any game object (preferrably the camera) to activate the script
    [SerializeField] string message;
    // Start is called before the first frame update
    void Start()
    {
        Flip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Flip()
    {
        string[] letter = message.Split(' ');

        for (int r = letter.Length - 1; r >= 0; r--)
        {
            letter[r] = string.Join("", letter[r].Reverse()); //Reverses letters
            Debug.Log(string.Join(" ", letter)); //Combines words back to one string
        }
    }
}
