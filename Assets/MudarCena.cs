using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour {

	// Update is called once per frame
	public void GoToScene (string qualCena) {
        SceneManager.LoadScene(qualCena);
        Debug.Log("Changing to scene " + qualCena);
	}
}
