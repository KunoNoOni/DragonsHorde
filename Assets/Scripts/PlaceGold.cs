using UnityEngine;
using System.Collections;

public class PlaceGold : MonoBehaviour 
{
	public GameObject gold;

	StoreDifficulty gd;
	GameVariables gv;
	float randomNumberX;
	float randomNumberY;
	int numGold;

	void Start()
	{
		Physics2D.gravity = Vector3.zero;
		gd = GameObject.Find("Difficulty").GetComponent<StoreDifficulty>();
		gv = GameObject.Find("GameVariables").GetComponent<GameVariables>();

		switch(gd.gameDifficulty)
		{
			case 1:
			{
				numGold = 75;
				gv.horde = 75;
				break;
			}
			case 2:
			{
				numGold = 50;
				gv.horde = 50;
				break;
			}
			case 3:
			{
				numGold = 25;
				gv.horde = 25;
				break;
			}
			case 4:
			{
				numGold = 10;
				gv.horde = 10;
				break;
			}
		}

		for(int x=0;x<numGold;x++)
		{
			randomNumberX = Random.Range(-5f,-4f);
			randomNumberY = Random.Range(-3f,3f);
			
			gv.goldList.Add(gold);
			Instantiate(gold,new Vector3(randomNumberX,randomNumberY,0),Quaternion.identity);
		}
	}
}
