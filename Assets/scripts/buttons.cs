using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class buttons : MonoBehaviour
{
    void OnMouseDown () {
        transform.localScale = new Vector3 (1.2f, 1.2f, 1.2f);
    }

    void OnMouseUp ()
    {
        transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
    }
}
