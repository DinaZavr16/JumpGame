using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAni : MonoBehaviour
{
    private SpriteRenderer bear;
    private void Start()
    {
        bear = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 5f);
    }
    private void Update()
    {
        bear.color = new Color(bear.color.r, bear.color.g, bear.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));
    }
}
