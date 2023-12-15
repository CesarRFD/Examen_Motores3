using Photon.Pun;
using Photon.Pun.Demo.SlotRacer.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private PhotonView view;
    [SerializeField] private Animator anim;

    private void Start()
    {
        anim = GetComponentInParent<Animator>();
    }

    private void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetKey("d"))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                anim.SetFloat("X", 1);
                anim.SetFloat("Y", 0);
            }
            if (Input.GetKey("a"))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                anim.SetFloat("X", -1f);
                anim.SetFloat("Y", 0);
            }
            if (Input.GetKey("w"))
            {
                transform.position += Vector3.forward * speed * Time.deltaTime;
                anim.SetFloat("X", 0);
                anim.SetFloat("Y", 1);
            }
            if (Input.GetKey("s"))
            {
                transform.position += Vector3.back * speed * Time.deltaTime;
                anim.SetFloat("X", 0);
                anim.SetFloat("Y", -1f);
            }
            if (!Input.GetKey("d") && !Input.GetKey("a") && !Input.GetKey("w") && !Input.GetKey("s"))
            {
                anim.SetFloat("X", 0);
                anim.SetFloat("Y", 0);
            }
        }
    }
}