using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class buttons : MonoBehaviour
{
    void OnMouseDown () {
        transform.localScale = new Vector3 (0.55f, 0.55f, 0.55f);
    }

    void OnMouseUp ()
    {
        transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
    }
}
