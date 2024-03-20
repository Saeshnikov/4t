using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject self;
    private void OnColliderEnter(Collider other)
    {
        if (other.CompareTag("Units"))
        {
            Destroy(this.gameObject);
            Destroy(self);
            self = null;
        }
    }
}
