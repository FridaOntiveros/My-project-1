using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // variable tipo gameobject
    public GameObject player;

    public Vector3 offset = new Vector3(0,6,-6);

    private void Update()
    {
        this.transform.position = player.transform.position + offset;
    }
}
