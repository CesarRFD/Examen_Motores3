using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarRagdoll : MonoBehaviour
{
    [SerializeField] private Rigidbody[] ragdollRigidbodies;
    [SerializeField] public bool ragdoll = true;

    void Start()
    {
        /*ragdollRigidbodies = new Rigidbody[]
        {
            GetComponentInChildren<Rigidbody>(),
        };*/
    }

    void Update()
    {
        ToggleRagdoll(ragdoll);
    }

    void ToggleRagdoll(bool enableRagdoll)
    {
        foreach (Rigidbody rb in ragdollRigidbodies)
        {
            rb.isKinematic = !enableRagdoll;
        }
    }
}
