using UnityEngine;
using System.Collections;

public class MoveKnight : MonoBehaviour 
{
	public float speed;

	void Start()
	{
		Physics2D.gravity = Vector3.zero;
	}

	void Update () 
	{
		float move = speed*Time.deltaTime;
		transform.Translate(new Vector3(-move,0,0));
	}
}
