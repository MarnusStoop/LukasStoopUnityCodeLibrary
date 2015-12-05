using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioMenuUI : MonoBehaviour
{
	public GameObject optionsMenu;
	public GameObject audioMenu;

	public void GoBack()
	{
		optionsMenu.SetActive(true);
		audioMenu.SetActive(false);
	}



}