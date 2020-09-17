using UnityEngine;
using System.Collections;


public class SpawnBlocks : MonoBehaviour
{
    public GameObject block;
    private GameObject blockInst;
    private Vector3 blockPos;
    private float speed = 4;

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

        blockPos = new Vector3 (Random.Range (0.9f, 1.7f), Random.Range(-3.2f, 1f), -1.4f);
        blockInst = Instantiate(block, new Vector3(5f, -6f, 0f), Quaternion.identity) as GameObject;
    }

    void Update () {
    	if (blockInst.transform.position != blockPos)
    	blockInst.transform.position = Vector3.MoveTowards (blockInst.transform.position, blockPos, Time.deltaTime * speed);
    }
}
