using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeCameraY : MonoBehaviour
{
  private float initialY;
  public float smoothTime = 0.1f; // Adjust this value to control smoothness

  void Start()
  {
    initialY = transform.position.y;
  }

  void Update() // Use LateUpdate for camera movement after other updates
  {
    // Option 1: Using local rotation for efficiency (recommended)
    transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 0f, transform.localEulerAngles.z);
  }
}


