using UnityEngine;
using System.Collections;

public class FallCube : MonoBehaviour
{

    private void CheckObject()
    {
        if (!gameObject)
            Debug.Log("Не найден gameObject");
    } 
    void Start()
    {
        CheckObject();
        Destroy(gameObject, 1f);
    }

    void Update()
    {
        transform.position -= new Vector3(0, 0.1f, 0);
    }
}

