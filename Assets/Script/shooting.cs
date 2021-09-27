using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public Transform bulletdirection;
    public GameObject mybullet;
    //public float Bforce = 25f;
    //public GameObject fallingobj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Z))
        {
            releasebullet();
        }  
    }

    public void releasebullet()
    {
        GameObject mybulletrelease = Instantiate(mybullet, bulletdirection.position, bulletdirection.rotation);
        Rigidbody2D bulletrb = mybulletrelease.GetComponent<Rigidbody2D>();
        //bulletrb.AddForce(bulletdirection.up * Bforce, ForceMode2D.Impulse);
    }

    public void OnCollisionEnter2D(Collision2D fallingob)
    {
        if (fallingob.gameObject.name == "fallOb")
        {
            Destroy(this.gameObject);
            Destroy(fallingob.gameObject);
            //fallingobj.SetActive(false);
        }


     
      

    }

    
}
