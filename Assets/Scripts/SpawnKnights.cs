using UnityEngine;
using System.Collections;

public class SpawnKnights : MonoBehaviour 
{
	public GameObject blueKnight;
	public GameObject redKnight;
	public GameObject yellowKnight;
	public GameObject purpleKnight;
	public GameObject pinkKnight;

	float YPosition1;
	float YPosition2;
	float YPosition3;
	float chanceForNextLevelKnight;


	GameVariables gv;

	void Start()
	{
		gv = GameObject.Find("GameVariables").GetComponent<GameVariables>();
		StartCoroutine(SpawnTheKnights());
	}

	public IEnumerator SpawnTheKnights()
	{
		switch(gv.WaveNum)
		{
			case 1:
			{
				while(gv.numSpawned < gv.totalKnightsInWave)
				{
					yield return new WaitForSeconds(1f);
					chanceForNextLevelKnight = Random.Range(0,100);
					if(chanceForNextLevelKnight >= 80)
					{
						YPosition1 = Random.Range(-2f, 2f);
						YPosition2 = Random.Range(-2f, 2f);	
						YPosition3 = Random.Range(-2f, 2f);	
						Instantiate(blueKnight,new Vector3(8f,Mathf.Round(YPosition1),0),Quaternion.identity);
						Instantiate(blueKnight,new Vector3(8f,Mathf.Round(YPosition2),0),Quaternion.identity);
						Instantiate(redKnight,new Vector3(8f,Mathf.Round(YPosition3),0),Quaternion.identity);	
						gv.numSpawned+=3;
					}
					else
					{
						YPosition1 = Random.Range(-2f, 2f);
						YPosition2 = Random.Range(-2f, 2f);
						YPosition3 = Random.Range(-2f, 2f);
						Instantiate(blueKnight,new Vector3(8f,Mathf.Round(YPosition1),0),Quaternion.identity);
						Instantiate(blueKnight,new Vector3(8f,Mathf.Round(YPosition2),0),Quaternion.identity);
						Instantiate(blueKnight,new Vector3(8f,Mathf.Round(YPosition3),0),Quaternion.identity);
						gv.numSpawned+=3;
					}
					//Debug.Log ("totalKnightsInWave= "+gv.totalKnightsInWave);
					//Debug.Log("NumSpawned = "+gv.numSpawned);
				}
				//Debug.Log("setting gv.numSpawned to 0");
				gv.numSpawned = 0;
				break;
			}
			case 2:
			{
				while(gv.numSpawned < gv.totalKnightsInWave)
				{
					//Debug.Log("gv.KnightsLeft > 0");
					yield return new WaitForSeconds(2f);
				chanceForNextLevelKnight = Random.Range(0,100);
				if(chanceForNextLevelKnight >= 80)
				{
					YPosition1 = Random.Range(-2f, 2f);
					YPosition2 = Random.Range(-2f, 2f);
					YPosition3 = Random.Range(-2f, 2f);
					Instantiate(redKnight,new Vector3(7f,Mathf.Round(YPosition1),0),Quaternion.identity);
					Instantiate(redKnight,new Vector3(7f,Mathf.Round(YPosition2),0),Quaternion.identity);
					Instantiate(yellowKnight,new Vector3(7f,Mathf.Round(YPosition3),0),Quaternion.identity);
					gv.numSpawned+=3;
				}
				else
				{
					YPosition1 = Random.Range(-2f, 2f);
					YPosition2 = Random.Range(-2f, 2f);
					YPosition3 = Random.Range(-2f, 2f);
					Instantiate(redKnight,new Vector3(7f,Mathf.Round(YPosition1),0),Quaternion.identity);
					Instantiate(redKnight,new Vector3(7f,Mathf.Round(YPosition2),0),Quaternion.identity);
					Instantiate(redKnight,new Vector3(7f,Mathf.Round(YPosition3),0),Quaternion.identity);
					gv.numSpawned+=3;
				}
					//Debug.Log ("totalKnightsInWave= "+gv.totalKnightsInWave);
					//Debug.Log("NumSpawned = "+gv.numSpawned);
				}
				//Debug.Log("setting gv.numSpawned to 0");
				gv.numSpawned = 0;
				break;
			}
			case 3:
			{
				while(gv.numSpawned < gv.totalKnightsInWave)
				{
					//Debug.Log("gv.KnightsLeft > 0");
					yield return new WaitForSeconds(3f);
					chanceForNextLevelKnight = Random.Range(0,100);
					if(chanceForNextLevelKnight >= 80)
					{
						YPosition1 = Random.Range(-2f, 2f);
						YPosition2 = Random.Range(-2f, 2f);
						YPosition3 = Random.Range(-2f, 2f);
						Instantiate(yellowKnight,new Vector3(7f,Mathf.Round(YPosition1),0),Quaternion.identity);
						Instantiate(yellowKnight,new Vector3(7f,Mathf.Round(YPosition2),0),Quaternion.identity);
						Instantiate(purpleKnight,new Vector3(7f,Mathf.Round(YPosition3),0),Quaternion.identity);
						gv.numSpawned+=3;
					}
					else
					{
						YPosition1 = Random.Range(-2f, 2f);
						YPosition2 = Random.Range(-2f, 2f);
						YPosition3 = Random.Range(-2f, 2f);
						Instantiate(yellowKnight,new Vector3(7f,Mathf.Round(YPosition1),0),Quaternion.identity);
						Instantiate(yellowKnight,new Vector3(7f,Mathf.Round(YPosition2),0),Quaternion.identity);
						Instantiate(yellowKnight,new Vector3(7f,Mathf.Round(YPosition3),0),Quaternion.identity);
						gv.numSpawned+=3;
					}
					//Debug.Log ("totalKnightsInWave= "+gv.totalKnightsInWave);;
					//Debug.Log("NumSpawned = "+gv.numSpawned);
				}
				//Debug.Log("setting gv.numSpawned to 0");
				gv.numSpawned = 0;
				break;
			}
			case 4:
			{
				while(gv.numSpawned < gv.totalKnightsInWave)
				{
					//Debug.Log("gv.KnightsLeft > 0");
					yield return new WaitForSeconds(4f);
					chanceForNextLevelKnight = Random.Range(0,100);
					if(chanceForNextLevelKnight >= 80)
					{
						YPosition1 = Random.Range(-2f, 2f);
						YPosition2 = Random.Range(-2f, 2f);
						YPosition3 = Random.Range(-2f, 2f);
						Instantiate(purpleKnight,new Vector3(7f,Mathf.Round(YPosition1),0),Quaternion.identity);
						Instantiate(purpleKnight,new Vector3(7f,Mathf.Round(YPosition2),0),Quaternion.identity);
						Instantiate(pinkKnight,new Vector3(7f,Mathf.Round(YPosition3),0),Quaternion.identity);
						gv.numSpawned+=3;
					}
					else
					{
						YPosition1 = Random.Range(-2f, 2f);
						YPosition2 = Random.Range(-2f, 2f);
						YPosition3 = Random.Range(-2f, 2f);
						Instantiate(purpleKnight,new Vector3(7f,Mathf.Round(YPosition1),0),Quaternion.identity);
						Instantiate(purpleKnight,new Vector3(7f,Mathf.Round(YPosition2),0),Quaternion.identity);
						Instantiate(purpleKnight,new Vector3(7f,Mathf.Round(YPosition3),0),Quaternion.identity);
						gv.numSpawned+=3;
					}
					//Debug.Log ("totalKnightsInWave= "+gv.totalKnightsInWave);
					//Debug.Log("NumSpawned = "+gv.numSpawned);
				}
				//Debug.Log("setting gv.numSpawned to 0");
				gv.numSpawned = 0;
				break;
			}
			case 5:
			{
				while(gv.numSpawned < gv.totalKnightsInWave)
				{
					yield return new WaitForSeconds(5f);
					YPosition1 = Random.Range(-2f, 2f);
					YPosition2 = Random.Range(-2f, 2f);
					YPosition3 = Random.Range(-2f, 2f);
					Instantiate(pinkKnight,new Vector3(7f,Mathf.Round(YPosition1),0),Quaternion.identity);
					Instantiate(pinkKnight,new Vector3(7f,Mathf.Round(YPosition2),0),Quaternion.identity);
					Instantiate(pinkKnight,new Vector3(7f,Mathf.Round(YPosition3),0),Quaternion.identity);
					gv.numSpawned+=3;
					//Debug.Log ("totalKnightsInWave= "+gv.totalKnightsInWave);
					//Debug.Log("NumSpawned = "+gv.numSpawned);
				}
				//Debug.Log("setting gv.numSpawned to 0");
				//gv.numSpawned = 0;
				break;
			}
		}
	}

}
