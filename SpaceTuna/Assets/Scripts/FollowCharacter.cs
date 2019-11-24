using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    float limix, limity1, limity2;
    //private Vector3 velocity = Vector3.zero;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
<<<<<<< Updated upstream
        if (player.transform.position.y >= -3.19 )
=======
        if (player.transform.position.y >= limity1 && player.transform.position.y <= limity2 && player.transform.position.x >= limix)
>>>>>>> Stashed changes
        {
           // Vector3 nouT =new Vector3(player.position.x, player.position.y, transform.position.z);
            //transform.position = Vector3.SmoothDamp(transform.position,nouT,ref velocity, 0.15f);
            transform.position = player.transform.position + offset;
        }
        else
        {
            if(player.transform.position.x >= limix) transform.position = new Vector3(player.transform.position.x + offset.x,transform.position.y, transform.position.z);
        }
    }
}
