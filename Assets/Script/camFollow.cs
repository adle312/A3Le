using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{

    public GameObject cameraFollowPlayer;
    //public Transform fallingobjfollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cameraFollowPlayer.transform.position.x, cameraFollowPlayer.transform.position.y, cameraFollowPlayer.transform.position.z -10);
        //transform.position = new Vector3(fallingobjfollow.transform.position.x, fallingobjfollow.transform.position.y, fallingobjfollow.transform.position.z - 10);
    }
}
