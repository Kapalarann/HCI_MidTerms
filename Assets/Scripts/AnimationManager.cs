using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class AnimationManager : MonoBehaviour
{
    public RectTransform image;
    public CanvasGroup alpha;
    private int fading = 1;
    public float shakeDuration, shakeStrength, rotateDuration, fadeDuration;
    private int rotated = 0;
    private float scale = 1f;

    public void Update()
    {
        alpha.alpha = Mathf.Lerp(alpha.alpha, 1f * fading, 0.05f);

        image.sizeDelta = new Vector2(221f, 100f) * Mathf.Lerp(image.sizeDelta.x/221f, scale, 0.05f);
    }
    public void Shake()
    {
        image.DOShakePosition(shakeDuration, shakeStrength, 10, 20, false);
    }

    public void Flip()
    {
        image.DORotate(Vector3.up * 180f * rotated, rotateDuration);
        if (rotated == 0) rotated = 1;
        else rotated = 0;
    }

    public void Fade()
    {
        if (fading == 0) { 
            fading = 1;
        }
        else { 
            fading = 0;
        }
    }

    public void Increase()
    {
        scale *= 1.2f;
    }

    public void Decrease()
    {
        scale /= 1.2f;
    }
}
