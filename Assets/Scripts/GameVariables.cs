using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameVariables : MonoBehaviour 
{
	public int horde;
	public int KnightsKilled;
	public int KnightsLeft;
	public int WaveNum;
	public int numSpawned;
	public int totalKnightsInWave;
	public Text knightsKilled;
	public Text goldLeft;
	public Text knightsLeft;
	public Text wave;
	public GameObject nextWave;
	public List<GameObject> goldList;

	bool levelPause;
	AudioSource asource;

	void Start()
	{
		levelPause = false;
		numSpawned = 0;
		List<GameObject> goldList = new List<GameObject>();
		asource = GetComponent<AudioSource>();

	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}

		knightsKilled.text = "Knights Killed: "+KnightsKilled;
		knightsLeft.text = "Knights Left This Wave: "+KnightsLeft;
		goldLeft.text = "Gold Piles Left: "+horde;
		wave.text = "Wave: "+WaveNum;

		if(KnightsLeft <= 0 && !levelPause)
		{
			StartCoroutine(BetweenLevelPause());
		}
	
		if(levelPause)
			StopCoroutine(BetweenLevelPause());

		if(horde <= 0)
			Application.LoadLevel("LoseScreen");
	}



	IEnumerator BetweenLevelPause()
	{
		//Debug.Log ("Running Coroutine");
		levelPause = true;
		if(WaveNum < 5)
		{
			nextWave.SetActive(true);
			yield return new WaitForSeconds(3f);
			WaveNum++;
			//Debug.Log ("WaveNum = "+WaveNum);
			KnightsLeft = 30;
			totalKnightsInWave = 30;
			//Debug.Log ("KnightsLeft updated");
			levelPause = false;
			//Debug.Log ("levelPause set");
			nextWave.SetActive(false);
			StartCoroutine(GameObject.Find("GameVariables").GetComponent<SpawnKnights>().SpawnTheKnights());
			//Debug.Log ("SpawnTheKnights Coroutine called");
		}
		else 
			Application.LoadLevel("WinScreen");
	}
}
