using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public CameraShake cameraShake;

    public void requestCameraShake()
    {
        shakeCamera();
    }

    private void shakeCamera()
    {
        StartCoroutine(cameraShake.Shake(.15f, .4f));
    }
}
