using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {

    public GameObject player;

    Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = player.transform.position - transform.position;
	}

    // Update is called once per frame
    void Update ()
    {
        transform.position = new Vector3(player.transform.position.x - offset.x,
                                         transform.position.y,
                                         player.transform.position.z - offset.z);
    }
}
