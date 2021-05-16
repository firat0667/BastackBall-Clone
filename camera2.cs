using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject targetobject;
    public Vector3 cameraoffset;
    public Vector3 targetpossition;
    private Vector3 velocity = Vector3.zero;

    public float smoothTime = 0.3f;
    void Start()
    {

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        targetpossition = targetobject.transform.position + cameraoffset;
        transform.position = Vector3.SmoothDamp(transform.position, targetpossition, ref velocity, smoothTime);
    }
}
