using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class buttons : MonoBehaviour
{
    void OnMouseDown () {
        transform.localScale = new Vector3 (0.02f, 0.02f, 0.02f);
    }

    void OnMouseUp ()
    {
        transform.localScale = new Vector3 (0.022f, 0.022f, 0.022f);
    }
}
