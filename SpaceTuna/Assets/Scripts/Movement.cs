﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rgdb;
    [SerializeField]
    float speed;

<<<<<<< Updated upstream
    private bool _isGrounded = true; // is player on the ground?
=======
    [SerializeField]
    GameObject attack;


    private bool faceR = true; // is player on the ground?
>>>>>>> Stashed changes
    private float time;
    Animator animator;

    //some flags to check when certain animations are playing
    bool _isPlaying_jump = false;

    //animation states - the values in the animator conditions
    const int STATE_IDLE = 0;
    const int STATE_WALK = 3;
    const int STATE_DEATH = 4;
    const int STATE_JUMP = 2;

    public int _currentAnimationState = STATE_IDLE;
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
<<<<<<< Updated upstream
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
            transform.position += Vector3.up * +speed * Time.deltaTime;
            time = 0;
        }

        if(time>0.01f) animator.SetInteger("state", STATE_IDLE);

        time += Time.deltaTime;
=======
        if (_currentAnimationState != STATE_DEATH)
        {
            float movementHoritzontal = Input.GetAxis("Horizontal");
            // Debug.Log(movementHoritzontal);
            float movementVertical = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(movementHoritzontal, movementVertical);

            if (movementHoritzontal < 0)
            {
                if (_currentAnimationState != STATE_WALK) animator.SetInteger("state", STATE_WALK);
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                transform.position += Vector3.right * -speed * Time.deltaTime;
                faceR = false;
                time = 0;
                _isPlaying_jump = false;
            }

            if (movementHoritzontal > 0)
            {
                if (_currentAnimationState != STATE_WALK) animator.SetInteger("state", STATE_WALK);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                transform.position += Vector3.right * speed * Time.deltaTime;
                faceR = true;
                time = 0;
                _isPlaying_jump = false;
            }

            if (movementVertical > 0)
            {
                if (_currentAnimationState != STATE_JUMP) animator.SetInteger("state", STATE_JUMP);
                transform.position += Vector3.up * (3 + speed) * Time.deltaTime;
                _isPlaying_jump = true;
                time = 0;
            }

            if (time > 0.01f && _isPlaying_jump == false) animator.SetInteger("state", STATE_IDLE);
            else if (time > 0.5f)
            {
                animator.SetInteger("state", STATE_IDLE);
                _isPlaying_jump = false;
            }

            time += Time.deltaTime;

            if (Input.GetKeyDown("space"))
            {
                if (faceR)
                {
                    Instantiate(attack, new Vector2(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y), Quaternion.Euler(0, 180, 0));
                }
                else
                {
                    attack.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    Instantiate(attack, new Vector2(this.gameObject.transform.position.x - 1, this.gameObject.transform.position.y), Quaternion.Euler(0, 0, 0));
                }
            }
        }
        else
        {
            animator.SetInteger("state", STATE_DEATH);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "background")
        {
            if (animator.GetInteger("state").Equals(STATE_JUMP))
            {
                animator.SetInteger("state", STATE_IDLE);
                _isPlaying_jump = false;
            }
        }
>>>>>>> Stashed changes
    }
}
