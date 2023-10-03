using UnityEngine;
using System.Collections;
using System;

public class Debris : MonoBehaviour
{

    private SpriteRenderer renderer2D;
    private Color startColor;
    private Color endColor;
    private float t = 0f;


    // Use this for initialization
    void Start()
    {

        renderer2D = GetComponent<SpriteRenderer>();
        startColor = renderer2D.color;
        endColor = new Color(startColor.r, startColor.g, startColor.b, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        renderer2D.material.color = Color.Lerp(startColor, endColor, t / 2);

        Debug.Log(string.Format("t = {0}", t));

        if (renderer2D.material.color.a <= 0f)
        {
            Debug.Log("debris destroyed");
            Destroy(gameObject);
        }
    }
}
