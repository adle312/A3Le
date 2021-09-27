using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallingobstacle : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D obstaclerb;
    public float wallhealth = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        obstaclerb = this.GetComponent<Rigidbody2D>();
        obstaclerb.velocity = new Vector2(0, speed);

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter2D(Collision2D themainLand)
    {
        if (themainLand.gameObject.name == "ground")
        {
            Destroy(this.gameObject);
        }

        else if (themainLand.gameObject.tag == "mainLand")
        {
            Destroy(this.gameObject);
        }
        else if (themainLand.gameObject.name == "character")
        {
            SceneManager.LoadScene("GGscene");
        }
        else if (themainLand.gameObject.name =="theDeath")
        {
            Destroy(this.gameObject);
        }
        else if (themainLand.gameObject.tag == "blockx")
        {
            Destroy(this.gameObject);
            wallhealth -= 1f;
            if (wallhealth <= 0)
            {
                Destroy(themainLand.gameObject);
            }
        }
    
      
    }
}
