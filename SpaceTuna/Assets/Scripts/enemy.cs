using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject vida, vida1, vida2;

    [SerializeField]
    float x_main,y_main;

    float x, y;

    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector2(x, y);
    }

    [System.Obsolete]
    void OnTriggerEnter2D(Collider2D col)
    {
            if (col.gameObject.name == "character")
            {
                col.gameObject.SetActive(false);
                if (vida.active)
                {
                    vida.gameObject.SetActive(false);
                    col.transform.position = new Vector2(x_main, y_main);
                    col.gameObject.SetActive(true);
                    col.gameObject.GetComponent<Movement>()._currentAnimationState = 0;
                }
                else if (vida1.active)
                {
                    vida1.gameObject.SetActive(false);
                    col.transform.position = new Vector2(x_main, y_main);
                col.gameObject.SetActive(true);
                    col.gameObject.GetComponent<Movement>()._currentAnimationState = 0;
                }
                else if (vida2.active)
                {
                    vida2.gameObject.SetActive(false);
                    Application.LoadLevel(4);
                }
            }
            else if (col.gameObject.name == "attack_main(Clone)")
            {
                this.gameObject.SetActive(false);
                col.gameObject.SetActive(false);
            }
        
    }
}
