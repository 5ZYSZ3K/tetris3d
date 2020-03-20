using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Globals;
using UnityEngine.UI;

public class txt : MonoBehaviour
{
    public Text txt1;
    string a;
    // Start is called before the first frame update
    void Start()
    {
        a = Globals.score.ToString();
        txt1.text = "Thank you for playing the game! Your score is " + a;
    }
}