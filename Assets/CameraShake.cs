using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Camera camera;

    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = camera.transform.localPosition;

        float elapse = 0.0f;

        while (elapse < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            camera.transform.localPosition = new Vector3(x, y, originalPos.z);

            elapse += Time.deltaTime;

            yield return null;
        }

        camera.transform.localPosition = originalPos;
    }
}
