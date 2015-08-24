using UnityEngine;
using System.Collections;

public class HowToPlay : MonoBehaviour 
{
	public GameObject howToPlayImage;
	public GameObject nextButton;
	public GameObject howToPlayTipsImage;
	public GameObject backButton;

	public void NextButton()
	{
		howToPlayImage.SetActive(false);
		nextButton.SetActive(false);
		howToPlayTipsImage.SetActive(true);
		backButton.SetActive(true);
	}
}
