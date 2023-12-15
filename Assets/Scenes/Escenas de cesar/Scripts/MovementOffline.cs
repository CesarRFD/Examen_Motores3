using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOffline : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Animator anim;

    private void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            anim.SetBool("walk", true);
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            anim.SetBool("walk", true);
        }
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            anim.SetBool("walk", true);
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
            anim.SetBool("walk", true);
        }
        if (!Input.GetKey("d") && !Input.GetKey("a") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            anim.SetBool("walk", false);
        }
        if (Input.GetKey("q"))
        {
            anim.SetBool("dance", true);
        }
        else
        {
            anim.SetBool("dance", false);
        }
    }
}