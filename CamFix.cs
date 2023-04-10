using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFix : MonoBehaviour
{
    void Start()
    {
        GameObject mainCamera = GameObject.Find("Main Camera");

        Camera.main.orthographicSize = (720 * (16f / 9f) / 2) / 100;

        Camera.main.aspect = 16f / 9f;

        float camHalfHeight = Camera.main.orthographicSize;
        float camHalfWidth = Camera.main.aspect * camHalfHeight;

        mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, camHalfHeight, mainCamera.transform.position.z);

        Vector3 topLeftPosition = new Vector3(-camHalfWidth, camHalfHeight, 0) + Camera.main.transform.position;
        print("Top Left : " + topLeftPosition);
    }
}