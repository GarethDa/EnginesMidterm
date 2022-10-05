using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            PlayerController.instance.ChangeFireSpeed(0.3f);
            Destroy(gameObject);
        }
    }
}
