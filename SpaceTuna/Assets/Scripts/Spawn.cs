using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeReference]
    GameObject character;

    private bool fly = false;
    // Start is called before the first frame update
    void Start()
    {
        character.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fly==true)
        {
            transform.position= new Vector2(this.transform.position.x, this.transform.position.y+2*Time.deltaTime);
            if (transform.position.y >= 20)
            {
                //Destroy(this.gameObject);
                fly = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "background")
        {
            character.SetActive(true);
            Destroy(this.GetComponent<Rigidbody2D>());
            Destroy(this.GetComponent<Collider2D>());
            Invoke("eliminate", 2);
        }
    }

    void eliminate()
    {
        fly = true;
    }
}
