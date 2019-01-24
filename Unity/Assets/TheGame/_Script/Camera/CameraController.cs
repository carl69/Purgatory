using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private Transform tagetParent;

    public Vector3 offset;

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
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        tagetParent.Rotate(0, horizontal, 0);


        //get the y position of the mouse and rotates the pivot 
        float vertical = Input.GetAxis("Mouse Y") *rotateSpeed;

        //
        if (invertedY)
        {
            vertical = -vertical;
        }

        pivot.Rotate(-vertical, 0, 0);

        if(pivot.rotation.eulerAngles.x > 45f && pivot.rotation.eulerAngles.x < 180f)
        {
            pivot.rotation = Quaternion.Euler(45f, 0, 0);
        }

        if (pivot.rotation.eulerAngles.x > 180f && pivot.rotation.eulerAngles.x < 300f)
        {
            pivot.rotation = Quaternion.Euler(300f, 0, 0);
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
