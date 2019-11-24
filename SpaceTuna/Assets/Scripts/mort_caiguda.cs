using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mort_caiguda : MonoBehaviour
{
    [SerializeField]
    float x_inici, y_inic, y_mort;

    [SerializeField]
    GameObject vida, vida1, vida2;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < y_mort)
        {
            if (vida.active)
            {
                vida.gameObject.SetActive(false);
                transform.position = new Vector2(x_inici, y_inic);
                gameObject.SetActive(true);
                gameObject.GetComponent<Movement>()._currentAnimationState = 0;
            }
            else if (vida1.active)
            {
                vida1.gameObject.SetActive(false);
                transform.position = new Vector2(x_inici, y_inic);
                gameObject.SetActive(true);
                gameObject.GetComponent<Movement>()._currentAnimationState = 0;
            }
            else if (vida2.active)
            {
                vida2.gameObject.SetActive(false);
                Application.LoadLevel(4);
            }
        }
    }
}
