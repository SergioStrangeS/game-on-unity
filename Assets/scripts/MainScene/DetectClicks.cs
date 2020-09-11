using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class DetectClicks : MonoBehaviour
{
	public GameObject buttons, m_cube;
	public Text playText, gameName;

	private bool clicked;

    void OnMouseDown() {
    	if (!clicked) {
    		clicked = true; // Works only ones
    		playText.gameObject.SetActive (false);
    		gameName.text = "0";
    		buttons.GetComponent <scrollObjects> ().speed = -5f;
    		buttons.GetComponent <scrollObjects> ().checkPos = -100f;
    		m_cube.GetComponent <Animation> ().Play ("StartGameCube");
    	}
    }

}
