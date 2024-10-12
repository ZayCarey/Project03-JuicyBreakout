using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAnimation : MonoBehaviour
{
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void AnimatePaddle()
    {
        transform.localScale = new Vector3(originalScale.x * 1.2f, originalScale.y * 0.8f, originalScale.z);
        Invoke("ResetScale", 0.1f);
    }

    private void ResetScale()
    {
        transform.localScale = originalScale;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GetComponent<PaddleAnimation>().AnimatePaddle();
        }
    }
}
