using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GraphicsMenuUI : MonoBehaviour
{
	public GameObject optionsMenu;
	public GameObject graphicsMenu;

	public void GoBack()
	{
		optionsMenu.SetActive(true);
		graphicsMenu.SetActive(false);
	}

}