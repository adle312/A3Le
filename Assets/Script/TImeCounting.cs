using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TImeCounting : MonoBehaviour
{
    //float currentT;
    float startingtimegame = 0f;

    public Text countingx;
    // Start is called before the first frame update
    void Start()
    {
        countingx = GetComponent<Text>();
        startingtimegame = 180f;
    }

    // Update is called once per frame
    void Update()
    {
        startingtimegame -= 1 *Time.deltaTime;
        countingx.text = startingtimegame.ToString("0.0");

        if (startingtimegame <= 0)
        {
            SceneManager.LoadScene("WinnerSc");
        }

    }
}
