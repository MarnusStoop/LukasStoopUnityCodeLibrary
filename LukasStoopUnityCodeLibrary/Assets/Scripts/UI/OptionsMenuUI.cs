using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsMenuUI : MonoBehaviour
{
	public GameObject mainMenu;
	public GameObject optionsMenu;
	public GameObject audioMenu;
	public GameObject graphicsMenu;

	public void GoBack()
	{
		optionsMenu.SetActive(false);
		mainMenu.SetActive(true);
	}

	public void GoToAudio()
	{
		optionsMenu.SetActive(false);
		audioMenu.SetActive(true);
	}

	public void GoToGraphics()
	{
		optionsMenu.SetActive(false);
		graphicsMenu.SetActive(true);
	}

}