using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarRagdoll : MonoBehaviour
{
    [SerializeField] private List<Rigidbody> ragdollRigidbodies = new List<Rigidbody>();
    public bool ragdoll = true;

    void Start()
    {
        string[] boneNames = { "mixamorig:Hips", "mixamorig:LeftUpLeg", "mixamorig:LeftLeg", "mixamorig:RightUpLeg", "mixamorig:RightLeg", "mixamorig:Spine", "mixamorig:LeftArm", "mixamorig:LeftForeArm", "mixamorig:Head", "mixamorig:RightArm", "mixamorig:RightForeArm" };

        foreach (string boneName in boneNames)
        {
            GameObject boneObject = GameObject.Find(boneName);
            if (boneObject != null)
            {
                Rigidbody rb = boneObject.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    ragdollRigidbodies.Add(rb);
                }
            }
        }
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