using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public float moveSpeed = 6.0f;
   //public float jumpSpeed = 5.0f;
    public float drag = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 direction = new Vector3(0, 0, 0);

        Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward);
        forward.y = 0;

        Vector3 forwardForce = forward * Input.GetAxis("Vertical") * drag;

        Vector3 right = Camera.main.transform.TransformDirection(Vector3.right);
        right.y = 0;

        Vector3 rightForce = right * Input.GetAxis("Horizontal") * drag;

        if(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
            direction += rightForce;
        }

        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
            direction += forwardForce;
        }

        GetComponent<Rigidbody>().AddForce(direction.normalized * moveSpeed * drag);
    }
}
