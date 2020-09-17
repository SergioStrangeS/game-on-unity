using UnityEngine;
using System.Collections;

public class StarAnimation : MonoBehaviour
{
    private SpriteRenderer Star;
    private float _movementSpeed = 0.1f; // Скорость перемещения звезд

    void Start()
    {
        Star = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 5f);
    }
    void Update()
    {
        Star.color = new Color(Star.color.r, Star.color.g, Star.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));

        //Move star
        transform.position += transform.up * Time.deltaTime * _movementSpeed;
    }
}