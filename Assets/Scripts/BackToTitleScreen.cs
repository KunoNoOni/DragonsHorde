using UnityEngine;
using System.Collections;

public class BackToTitleScreen : MonoBehaviour 
{
	public void BackToTitleScreenButton()
	{
		Application.LoadLevel("Titlescreen");
	}

}
