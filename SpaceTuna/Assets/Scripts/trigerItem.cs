using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerItem : MonoBehaviour
{
    [SerializeField]
    GameObject nau;
    // Start is called before the first frame update

    float x, y;

    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        nau.SetActive(false);
    }

    void Update()
    {
        transform.position = new Vector2(x,y);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "character")
        {
            this.gameObject.SetActive(false);
            nau.SetActive(true);
        }
    }
}
    
