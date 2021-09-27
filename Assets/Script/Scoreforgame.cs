using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreforgame : MonoBehaviour
{
    public static int value = 0;
    public Text myscoregame;

   

    // Start is called before the first frame update
    void Start()
    {
        //scorex = GetComponent<Text>();
        myscoregame = GetComponent<Text>();
        Scoreforgame.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //scoregametxt.Text = "Score: " + scorex;
        myscoregame.text = "Score :" + value;
    }
}
