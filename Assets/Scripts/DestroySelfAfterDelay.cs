using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfAfterDelay : MonoBehaviour
{
    public float delay = 2f;

    void Start ()
    {
        Destroy(gameObject, delay);
    }
}
