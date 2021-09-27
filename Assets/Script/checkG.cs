using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkG : MonoBehaviour
{
    public GameObject mycharacterJmp;
    // Start is called before the first frame update
    void Start()
    {
        mycharacterJmp = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D mycheckGx)
    {
        if (mycheckGx.gameObject.tag == "mainLand")
        {
            mycharacterJmp.GetComponent<TheMainCharacter>().doublejumpallow = true;
            TheMainCharacter.numberofjump = 0;
        }
        else if (mycheckGx.gameObject.tag == "mainLand")
        {
            mycharacterJmp.GetComponent<TheMainCharacter>().doublejumpallow = false;
        }
    }
}
