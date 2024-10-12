using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickEntryAnimation : MonoBehaviour
{
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
        transform.localScale = Vector3.zero;
        StartCoroutine(ScaleIn());
    }

    IEnumerator ScaleIn()
    {
        float t = 0;
        while (t < 1)
        {
            transform.localScale = Vector3.Lerp(Vector3.zero, originalScale, t);
            t += Time.deltaTime;
            yield return null;
        }
        transform.localScale = originalScale;
    }
}