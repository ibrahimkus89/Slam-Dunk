using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformForce : MonoBehaviour
{
    [SerializeField] private float angle;
    [SerializeField] private float forceToApply;


    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(angle, 90, 0) * forceToApply, ForceMode.Force);
    }

}
