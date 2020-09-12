using UnityEngine;
using System.Collections;


public class SpawnBlocks : MonoBehaviour
{
    public GameObject block;

    private void CheckObject()
    {
        if(!block)
        {
            Debug.Log("Не найден объект block");
        }
    }
    void Start()
    {
        CheckObject();

        Instantiate(block, new Vector3(), Quaternion.identity);
    }
}
