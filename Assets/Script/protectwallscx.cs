using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protectwallscx : MonoBehaviour
{
    public float wallhp = 5f;
    public float lifetime = 0.2f;
    //public bool gameobjectdestroy = false;
    //public static int countwall = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wallhp == 0)
        {
            Destroy(this.gameObject, lifetime);
            //TheMainCharacter.onlytwoblocks = TheMainCharacter.onlytwoblocks + 1;
            //gameobjectdestroy = true;
        }
        
    }

    public void OnCollsionEnter2D(Collision2D mywall)
    {
        if (mywall.gameObject.tag == "fallO")
        {
            //DestrogameObject);
            Destroy(gameObject);
            wallhp -= 1f;
        }
    }

}
