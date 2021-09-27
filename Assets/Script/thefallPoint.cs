using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thefallPoint : MonoBehaviour
{
    public GameObject fallobjz;
    private float randomPosX;
    Vector2 releasing;
    public float releaserate = -0.1f;
    float nextSp = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSp)
        {
            nextSp = Time.time + releaserate;
            randomPosX = Random.Range(-20.0f, 20.0f);
            releasing = new Vector2(randomPosX, transform.position.y);
            Instantiate(fallobjz, releasing, Quaternion.identity);
        }
    }
}
