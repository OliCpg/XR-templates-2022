using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTigger : MonoBehaviour
{
    [SerializeField] private Animator targetAnimator;

    //private void OnCollisionEnter(Collision collision)
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("XRhand"))
        {
            bool animatorCurrentValue = targetAnimator.GetBool("isOpen");
            targetAnimator.SetBool("isOpen", !animatorCurrentValue);
        }
    }
}
