using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shareMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed;
    [SerializeField] Transform p2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        Vector3 directionP2 = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector3.up;
            directionP2 += Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector3.down;
            directionP2 += Vector3.down;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector3.right;
            directionP2 += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector3.left;
            directionP2 += Vector3.left;
        }
        // wasd

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.up;
            directionP2 += Vector3.down;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.down;
            directionP2 += Vector3.up;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
            directionP2 += Vector3.left;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
            directionP2 += Vector3.right;
        }
        gameObject.transform.position += direction.normalized * speed * Time.deltaTime;
        p2.transform.position += directionP2.normalized * speed * Time.deltaTime;
    }
}
