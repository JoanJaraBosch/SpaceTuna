using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.y==180)
        {
            transform.position += Vector3.right * 2 * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.right * -2 * Time.deltaTime;
        }
    }
}
