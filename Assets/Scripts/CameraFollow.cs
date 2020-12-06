using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    public GameObject leftWall;

    private void Start()
    {
        float width = gameObject.GetComponent<Camera>().aspect * (gameObject.GetComponent<Camera>().orthographicSize * 2);

        leftWall.transform.position = new Vector3(transform.position.x - (width / 2), leftWall.transform.position.y, leftWall.transform.position.z);
    }

    void Update()
    {
        if (player.transform.position.x >= transform.position.x) {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
