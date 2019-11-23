using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rgdb;
    [SerializeField]
    float speed;

    private bool _isGrounded = true; // is player on the ground?
    private float time;
    Animator animator;

    //some flags to check when certain animations are playing
    bool _isPlaying_death = false;
    bool _isPlaying_jump = false;
    bool _isPlaying_walk = false;
    bool _isPlaying_run = false;

    //animation states - the values in the animator conditions
    const int STATE_IDLE = 0;
    const int STATE_WALK = 3;
    const int STATE_RUN = 1;
    const int STATE_JUMP = 2;
    const int STATE_DEATH = 4;

    int _currentAnimationState = STATE_IDLE;
    // Start is called before the first frame update
    void Start()
    {
        rgdb = GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
        time = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementHoritzontal = Input.GetAxis("Horizontal");
        // Debug.Log(movementHoritzontal);
        float movementVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(movementHoritzontal,movementVertical);
        
        if (movementHoritzontal < 0)
        {
            if(_currentAnimationState != STATE_WALK) animator.SetInteger("state", STATE_WALK);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            transform.position += Vector3.right * -speed * Time.deltaTime;
            time = 0;
        }

        if (movementHoritzontal > 0)
        {
            if (_currentAnimationState != STATE_WALK) animator.SetInteger("state", STATE_WALK);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            transform.position += Vector3.right * speed * Time.deltaTime;
            time = 0;
        }

        if (movementVertical > 0)
        {
            if (_currentAnimationState != STATE_JUMP) animator.SetInteger("state", STATE_JUMP);
            transform.position += Vector3.up * (3f + speed) * Time.deltaTime;
            time = 0;
        }

        if(time>0.01f) animator.SetInteger("state", STATE_IDLE);

        time += Time.deltaTime;
    }
}
