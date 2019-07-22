using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetatch : MonoBehaviour
{
    public void Detatch()
    {
        transform.parent = null;
    }
}
