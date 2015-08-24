using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour 
{
	public GameObject DifficultyPanel;
	public GameObject MainPanel;

	StoreDifficulty gd;

	void Start () 
	{
		gd = GameObject.Find("Difficulty").GetComponent<StoreDifficulty>();
	}


	public void HowToPlayButton()
	{
		Application.LoadLevel("HowToPlay");
	}

	public void DefendYourHordeButton()
	{
		MainPanel.SetActive(false);
		DifficultyPanel.SetActive(true);
	}

	public void ExitGameButton()
	{
		Application.Quit();
	}

	public void AncientButton()
	{
		gd.gameDifficulty = 1;
		Application.LoadLevel("Game");
	}

	public void OldButton()
	{
		gd.gameDifficulty = 2;
		Application.LoadLevel("Game");
	}

	public void AdultButton()
	{
		gd.gameDifficulty = 3;
		Application.LoadLevel("Game");
	}

	public void YoungButton()
	{
		gd.gameDifficulty = 4;
		Application.LoadLevel("Game");
	}
}
