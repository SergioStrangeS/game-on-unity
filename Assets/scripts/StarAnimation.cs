using UnityEngine;
using System.Collections;

public class StarAnimation : MonoBehaviour
{
    private SpriteRenderer Star;

    void Start()
    {
        Star = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 5f);
    }
    void Update()
    {
        Star.color = new Color(Star.color.r, Star.color.g, Star.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));
    }
}
