using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VowelCheck : MonoBehaviour
{
    //Place script onto any game object (preferrably the camera) to activate the script
    [SerializeField] string message;
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        vowelCheck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void vowelCheck()
    {
        string lowercase = message.ToLower();
        foreach (char v in lowercase)
        {
            if (v == 'a') //checking for vowels. I am sure there is a simpler way of doing this but I am trying to not spend a long time on this part
            {
                count++;
            }
            if (v == 'e')
            {
                count++;
            }
            if (v == 'i')
            {
                count++;
            }
            if (v == 'o')
            {
                count++;
            }
            if (v == 'u')
            {
                count++;
            }
        }
        /*for (int c = 0; c < message.Length; c++)
        {

        }*/ //was planning to use this for vowel check. Will work on this another time.

        Debug.Log(count);
    }
}
