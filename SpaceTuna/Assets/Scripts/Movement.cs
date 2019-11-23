using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rgdb;
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        rgdb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementHoritzontal = Input.GetAxis("Horizontal");
        // Debug.Log(movementHoritzontal);
        float movementVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(movementHoritzontal,movementVertical);
        
        if (movementHoritzontal < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            transform.position += Vector3.right * -speed * Time.deltaTime;
        }

        if (movementHoritzontal > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (movementVertical < 0)
        {
            transform.position += Vector3.up * -speed * Time.deltaTime;
        }

        if (movementVertical > 0)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
