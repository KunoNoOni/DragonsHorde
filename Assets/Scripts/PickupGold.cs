using UnityEngine;
using System.Collections;

public class PickupGold : MonoBehaviour 
{
	GameVariables gv;
	//GameObject gold;

	void Start()
	{
		gv = GameObject.Find("GameVariables").GetComponent<GameVariables>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.CompareTag("knight"))
		{
			gv.horde--;
			gv.KnightsLeft--;
			//Debug.Log (horde.horde);
			//gold = gv.goldList[0];
			//Debug.Log (gold);
			gv.goldList.RemoveAt(0);
			Destroy (GameObject.Find("Gold(Clone)"));
			Destroy (col.gameObject);
		}
	}
}

