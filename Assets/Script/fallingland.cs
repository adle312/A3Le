using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingland : MonoBehaviour
{
    public Rigidbody2D landrb;

    public Rigidbody2D protectland;

    public GameObject theFallingL;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D hittingland)
    {
        if (hittingland.gameObject.CompareTag("Player"))
        {
            StartCoroutine(landCollision());
            Scoreforgame.value += 5;
        }
        
        else if (hittingland.gameObject.name == "ground")
        {
            Destroy(this.gameObject);
            //theFallingL.SetActive(false);
            Destroy(theFallingL.gameObject);
        }



    }

    IEnumerator landCollision()
    {
        yield return new WaitForSeconds(0.1f);
        landrb.isKinematic = false;
        protectland.isKinematic = false;
    }


}
