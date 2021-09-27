using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setscoreWinner : MonoBehaviour
{
    public Text WinnerScoreText;
    // Start is called before the first frame update
    void Start()
    {
        WinnerScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        WinnerScoreText.text = "Score: " + Scoreforgame.value;
    }
}
