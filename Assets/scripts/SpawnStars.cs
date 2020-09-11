using UnityEngine;
using System.Collections;

public class SpawnStars : MonoBehaviour
{
    private GameObject Star;
    private Camera cam;

    void Start()
    {
        StartCoroutine("SpawnRandom");
        cam = Camera.main;
    }

    private IEnumerable SpawnRandom()
    {
        while(true)
        {
            Vector3 screenPosition = cam.ScreenToWorldPoint(
                new Vector3(
                Random.Range(0, Screen.width),
                Random.Range(0, Screen.height),
                cam.farClipPlane / 2f));
            Instantiate(Star, screenPosition, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
