using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{

    private void FixedUpdate()
    {
        transform.Rotate(0.1f, 0, 0);
    }
}
