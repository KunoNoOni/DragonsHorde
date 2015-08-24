using UnityEngine;
using System.Collections;

public class StoreDifficulty : MonoBehaviour 
{
	public int gameDifficulty;

	void Awake()
	{
		DontDestroyOnLoad(this);
	}
}
