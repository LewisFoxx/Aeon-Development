using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegionMenu : MonoBehaviour {

	public void MENU_ACTION_GoToPage(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
