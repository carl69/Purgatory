using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerV2 : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 _cameraOfset;

    public bool lookAtPlayer = true;

    public Transform pivot;

    [Range(0.01f, 1.0f)]
    public float Smoothfactor = 0.5f;


    public bool rotationAllow = true;
    public float rotateSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        _cameraOfset = transform.position - PlayerTransform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {


        //if (rotationAllow)
        //{
            Quaternion camChangeAngleHorizontal = Quaternion.AngleAxis(Input.GetAxis("CameraX_P1") * rotateSpeed, Vector3.up);
            _cameraOfset = camChangeAngleHorizontal *_cameraOfset;
        //}

        Vector3 newPosition = PlayerTransform.position + _cameraOfset;

        transform.position = Vector3.Slerp(transform.position, newPosition, Smoothfactor);

        if (lookAtPlayer || rotationAllow)
        {
            transform.LookAt(PlayerTransform);
        }
    }
}
