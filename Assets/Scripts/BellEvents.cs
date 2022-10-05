using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BellEvents : MonoBehaviour
{
    
}

public class HitBell : BellEvents
{
    bool wasHit = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Bullet")
        {
            wasHit = true;
        }
    }

    public bool WasHit()
    {
        return wasHit;
    }
}
