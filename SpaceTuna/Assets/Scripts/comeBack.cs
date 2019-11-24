using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class comeBack : MonoBehaviour
{
    [SerializeField]
    int level;

    private bool fly;
    // Start is called before the first frame update
    private float x,y;
    void Start()
    {
        fly = false;
        x = transform.position.x;
        y = transform.position.y;
    }

    [System.Obsolete]
    void Update()
    {
        if (fly == true)
        {
            transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 2 * Time.deltaTime);
            if (transform.position.y >= 20)
            {
                Destroy(this.gameObject);
                fly = false;
                Application.LoadLevel(level); 
            }
        }
        else
        {
            transform.position = new Vector2(x,y);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "character")
        {
            col.gameObject.SetActive(false);
            Destroy(GetComponent<Rigidbody2D>());
            fly = true;
        }
    }
}
