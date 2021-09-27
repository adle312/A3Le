using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class begintheRound : MonoBehaviour
{
    public GameObject beginthegame;
    public GameObject death;

    public float startingwithoutcollision = 5f;
    // Start is called before the first frame update
    void Start()
    {
        beginthegame.SetActive(true);
        death.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        startingwithoutcollision -= 1 * Time.deltaTime;
        if (startingwithoutcollision <= 0)
        {
            beginthegame.SetActive(false);
            death.SetActive(true);
            //Destroy(beginthegame);

            //SceneManager.LoadScene("GGscene");
        }
    }

    public void OnCollisionEnter2D(Collision2D collideplayer)
    {
        if (collideplayer.gameObject.name == "character")
        {
            beginthegame.SetActive(false);
            death.SetActive(true);
        }
    }
}
