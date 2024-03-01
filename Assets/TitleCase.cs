using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System.Linq;

public class TitleCase : MonoBehaviour
{
    //Place script onto any game object (preferrably the camera) to activate the script
    [SerializeField] string words;
    // Start is called before the first frame update
    void Start()
    {
        titleCase();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void titleCase()
    {
        string[] word = words.Split(' ');

        for (int w = 0; w < word.Length; w++)
        {
            char first = char.ToUpper(word[w][0]); //upper cases first letter of each word
            word[w] = first + word[w].Substring(1); //puts the first letter back to the word

        }
        string join = string.Join(" ", word); //combines words into the original message
        Debug.Log(join);
    }
}
