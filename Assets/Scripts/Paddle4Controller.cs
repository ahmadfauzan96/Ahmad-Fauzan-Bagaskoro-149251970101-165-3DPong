using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle4Controller : MonoBehaviour
{
    public float speed;
    public KeyCode leftKey;
    public KeyCode rightKey;

    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movePaddle = GetInput();

        moveObject(movePaddle);
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
        else if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        
        return Vector3.zero;
    }

    private void moveObject(Vector3 movePaddle)
    {
        rig.velocity = movePaddle;
    }
}
