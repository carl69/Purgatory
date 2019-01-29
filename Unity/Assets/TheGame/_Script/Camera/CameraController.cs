using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private Transform tagetParent;

    public Vector3 offset;

    public float maxAngle = 45;
    public float minAngle = 60;

    public float rotateSpeed;


    public Transform pivot;

    public bool invertedY;

    // Start is called before the first frame update
    void Start()
    {

        tagetParent = target.transform.parent;

        offset = target.position - transform.position;
        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float deadzone = 0.25f;
        Vector2 stickInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        if (stickInput.magnitude < deadzone)
            stickInput = Vector2.zero;
        else
            stickInput = stickInput.normalized * ((stickInput.magnitude - deadzone) / (1 - deadzone));

        float horizontal = stickInput.x * rotateSpeed;

        tagetParent.Rotate(0, horizontal, 0);

        //get the y position of the mouse and rotates the pivot 
        float vertical = stickInput.y * rotateSpeed;

        //
        if (invertedY)
        {
            vertical = -vertical;
        }

        pivot.Rotate(-vertical, 0, 0);

        if(pivot.rotation.eulerAngles.x > maxAngle && pivot.rotation.eulerAngles.x < 180f)
        {
            pivot.rotation = Quaternion.Euler(maxAngle, 0, 0);
        }

        if (pivot.rotation.eulerAngles.x > 180f && pivot.rotation.eulerAngles.x < 360f-minAngle)
        {
            pivot.rotation = Quaternion.Euler(360f - minAngle, 0, 0);
        }

        float desireAngleY = target.eulerAngles.y;
        float desireAngleX = pivot.eulerAngles.x;

        Quaternion rotation = Quaternion.Euler(desireAngleX, desireAngleY,0);
        transform.position = target.position - (rotation * offset);

        if(transform.position.y < target.transform.position.y - 0.5f)
        {
            transform.position = new Vector3(transform.position.x, target.transform.position.y - 0.5f, transform.position.z);
        }
        
        transform.LookAt(target);
    }
}
