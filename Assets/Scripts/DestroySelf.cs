using UnityEngine;
using System.Collections;

public class DestroySelf : MonoBehaviour 
{
	void Start()
	{
		StartCoroutine(DestroySelfNow());
	}

	IEnumerator DestroySelfNow()
	{
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);
		
	}
}
