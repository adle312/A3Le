using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonGame : MonoBehaviour
{
    public GameObject InstructionBoard;
    //public GameObject closeInsBoard;

    //ublic static int firstscorevalue = 0;
   //public Text scoreinbegin;


    void Start()
    {
        InstructionBoard.SetActive(false);
        //scoreinbegin = GetComponent<Text>();
    }

    void Update()
    {
        //scoreinbegin.text = "Score: " + firstscorevalue;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Frankengame");
        //Scoreforgame.value == 0;
        //scoreinbegin.text = "Score: " + firstscorevalue;
        //firstscorevalue = 0;
        //PlayerPrefs.SetInt("", firstscorevalue);
    }

    public void GameOverScene()
    {
        SceneManager.LoadScene("GGscene");
    }

    public void InstructionButton()
    {
        InstructionBoard.SetActive(true);
    }

    public void CloseInsButton()
    {
        InstructionBoard.SetActive(false);
    }

    public void BacktoMain()
    {
        SceneManager.LoadScene("GameIntro");
    }

    public void SaveScene()
    {
        SceneManager.LoadScene("WinnerSc");
    }

    
}
