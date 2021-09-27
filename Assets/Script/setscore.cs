using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setscore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text checkScoreAftergame;

    void Start()
    {
        //Debug.Log(Scoreforgame.value);
        checkScoreAftergame = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        checkScoreAftergame.text = "Score: " + Scoreforgame.value;
    }
}
