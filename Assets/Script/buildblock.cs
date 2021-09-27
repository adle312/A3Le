using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildblock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D buildbridge)
    {
        if (buildbridge.gameObject.name == "fallob")
        {
            Destroy(this.gameObject);
            Destroy(buildbridge.gameObject);
        }
    }
}
