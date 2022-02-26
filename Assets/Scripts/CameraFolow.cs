using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{

    public  GameObject player;
    private Vector3 CamInitPos;

    // Start is called before the first frame update
    void Start()
    {
        // gotta flex that big brain by taking the cameras global position and using that as a vector3 offset variable, assuming the player is at 0,0,0, if not then this could create allignment issues
        // though thats only an issue if being able to align the player view to the player model is of a concern, the main point of this line is so you can change offset without needing to do so manually or
        // going into the IDE, is the expmlanation a bit much? yes, shut up
        CamInitPos = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // have tha camera follow the player
        transform.position = player.transform.position + CamInitPos; // add an extra offset so we dont get a car crotch cam
    }
}
