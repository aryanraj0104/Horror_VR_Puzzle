using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneGyroCameraFixedYParent : MonoBehaviour
{
  public float rotationSensitivity = 1.0f; // Adjust sensitivity as needed

  void Update()
  {
    // Get gyroscope rotation (adjust based on your device orientation)
    Quaternion gyroRotation = Input.gyro.attitude;

    // Invert for some devices (check your device documentation)
    gyroRotation = Quaternion.Euler(0, 0, -gyroRotation.eulerAngles.z);

    // Apply rotation with sensitivity
    transform.rotation = Quaternion.Slerp(transform.rotation, gyroRotation, rotationSensitivity * Time.deltaTime);

    // Set fixed y-position relative to parent
    transform.localPosition = new Vector3(transform.localPosition.x, transform.parent.position.y, transform.localPosition.z);
  }
}


