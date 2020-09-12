using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DetectClicks : MonoBehaviour
{
    public GameObject[] cubes;
    public GameObject buttons, m_cube;
    public Light dirLight, dirLight_2;
    public Animation cubes_anim, block;
    public Text playText, gameName;

    private bool clicked;

    void Update()
    {
        if (clicked && dirLight.intensity != 0f)
            dirLight.intensity -= 0.03f;
        if (clicked && dirLight_2.intensity >= 1.05f)
            dirLight_2.intensity -= 0.025f;
    }

    void OnMouseDown()
    {
        if (!clicked)
        {
            StartCoroutine(delCubes());
            clicked = true; // Works only ones
            playText.gameObject.SetActive(false);
            gameName.text = "0";
            buttons.GetComponent<scrollObjects>().speed = -5f;
            buttons.GetComponent<scrollObjects>().checkPos = -100f;
            m_cube.GetComponent<Animation>().Play("StartGameCube");
            StartCoroutine(cubeToBlock());
            m_cube.transform.localScale = new Vector3(1f, 1f, 1f);
            cubes_anim.Play();
        }
    }

    IEnumerator delCubes()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(0.5f);
            cubes[i].GetComponent<FallCube>().enabled = true;
        }
    }

    IEnumerator cubeToBlock()
    {
        yield return new WaitForSeconds(m_cube.GetComponent<Animation>().clip.length + 0.3f);
        block.Play();
    }
}
