using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Camera cam;
    // Update is called once per frame
    void Update()
    {
        cam.transform.position = transform.position + new Vector3(0, 0, -1);
    }
}
