using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform player;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        if (player.position.y < 3.3 & offset.y < .36f)
        {

            offset.y = offset.y + .02f;
        }
        else if (player.position.y < 3.3 & offset.y < .4f)
        {
            offset.y = offset.y + .005f;
        }
        else if (player.position.y < 3.3 & offset.y < .5f)
        {
            offset.y = offset.y + .002f;
        }


    }
}
