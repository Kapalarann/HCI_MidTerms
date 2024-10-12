using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMovement : MonoBehaviour
{
    public float xVelocity, yVelocity;
    private RectTransform image;
    public float speed;
    public void Awake()
    {
        image = GetComponent<RectTransform>();
        float angle = 45f;
        xVelocity = Mathf.Cos(angle) * speed;
        yVelocity = Mathf.Sin(angle) * speed;
    }

    public void Update()
    {
        if(Mathf.Abs( image.anchoredPosition.x ) >= 960 - (image.sizeDelta.x/2)) xVelocity = - xVelocity;
        if (Mathf.Abs( image.anchoredPosition.y ) >= 540 - (image.sizeDelta.y / 2) ) yVelocity = - yVelocity;

        Vector2 move = new Vector2 (xVelocity, yVelocity);
        image.anchoredPosition += move * Time.deltaTime;
    }
}
