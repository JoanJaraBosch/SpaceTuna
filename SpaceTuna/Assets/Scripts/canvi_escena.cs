using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class canvi_escena : MonoBehaviour
{
    [SerializeField]
    GameObject pandas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Application.LoadLevel(1);
            Destroy(pandas);
            Destroy(this);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel(2);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(0);
        }
    }
}
