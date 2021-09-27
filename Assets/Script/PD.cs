using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D preventwall)
    {
        if (preventwall.gameObject.name == "ground")
        {
            Destroy(this.gameObject);
        }

        else if (preventwall.gameObject.tag == "mainLand")
        {
            Destroy(this.gameObject);
        }

        else if (preventwall.gameObject.name == "theDeath")
        {
            Destroy(this.gameObject);
        }
    }
}
