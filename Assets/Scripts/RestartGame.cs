using UnityEngine;

public class RestartGame : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Invoke("LoadLevel", 3f);
	}
	
	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width / 2 - 20, 10, 80, 20), "RESTART")) {
			Application.LoadLevel ("CongaScene");
		}
	}
}