using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuUI : MonoBehaviour
{
	public GameObject optionsMenu;
	public GameObject mainMenu;

	public void GoToOptions()
	{
		optionsMenu.SetActive(true);
		mainMenu.SetActive(false);
	}

	public void ExitGame()
	{
		Application.Quit();
	}

}