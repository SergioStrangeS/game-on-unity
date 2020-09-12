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

    private bool unblockCode = true; //Разблокируй, кок только появится анимация.

    private void CheckObjects()
    {
        if (!playText || !gameName)
        {
            Debug.Log("Не найден объект playText or gameName");
        }

        if (!buttons || !m_cube)
        {
            Debug.Log("Не найден объект buttons or m_cube");
        }
        if (!dirLight || !dirLight_2)
        {
            Debug.Log("Не найден объект dirLight or dirLight_2");
        }
        if (!cubes_anim || !block)
        {
            Debug.Log("Не найден объект cubes_anim or CubeToBlock");
        }
    }

    void Update()
    {
        if (clicked && dirLight.intensity != 0f)
            dirLight.intensity -= 0.03f;
        if (clicked && dirLight_2.intensity >= 1.05f)
            dirLight_2.intensity -= 0.025f;
    }

    void OnMouseDown()
    {
        CheckObjects();

        if (!clicked && unblockCode !=false)
        {
            StartCoroutine(deleteCubes());
            clicked = true; // Works only ones
            gameName.text = "0";
            playText.gameObject.SetActive(false);
            buttons.GetComponent<scrollObjects>().speed = -5f;
            buttons.GetComponent<scrollObjects>().checkPos = -100f;
            m_cube.GetComponent<Animation>().Play("StartGameCube");
            m_cube.transform.localScale = new Vector3(1f, 1f, 1f);

            StartCoroutine(cubeToBlock());
            cubes_anim.Play();
        }
    }

    IEnumerator deleteCubes()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(0.5f);
            cubes[i].GetComponent<FallCube>().enabled = true;
        }
    }

    IEnumerator cubeToBlock()
    {
        yield return new WaitForSeconds(m_cube.GetComponent<Animation>().GetClip("StartGameCube").length + 0.5f);
        block.Play();
    }
}
