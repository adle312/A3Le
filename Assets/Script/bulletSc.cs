using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D targetbullet)
    {
        if (targetbullet.gameObject.tag == "mainLand")
        {
            Destroy(this.gameObject);
        }
        if (targetbullet.gameObject.tag == "fallO")
        {
            Destroy(this.gameObject);
            Destroy(targetbullet.gameObject);
            Scoreforgame.value += 10;
        }
        if (targetbullet.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
