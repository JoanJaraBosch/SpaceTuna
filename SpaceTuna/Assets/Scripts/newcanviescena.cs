using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newcanviescena : MonoBehaviour
{
    // Start is called before the first frame update
    private int timer;
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        timer++;
        if (timer >= 240)
        {
            Application.LoadLevel(3);
        }
    }
}
