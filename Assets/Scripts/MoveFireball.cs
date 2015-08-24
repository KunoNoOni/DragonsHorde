using UnityEngine;
using System.Collections;

public class MoveFireball : MonoBehaviour 
{
	public GameObject BloodSplatter;
	//Rigidbody2D rb2d;
	GameVariables gv;
	KnightsHealth kh;
	AudioSource asource;

	void Start () 
	{
		Physics2D.gravity = Vector3.zero;
		gv = GameObject.Find("GameVariables").GetComponent<GameVariables>();
		asource = GameObject.Find("GameVariables").GetComponent<AudioSource>();
		//kh = GameObject.FindGameObjectWithTag("knight").GetComponent<KnightsHealth>();
		//rb2d = GetComponent<Rigidbody2D>();
		StartCoroutine(DestroySelf());
	}
	
	void Update () 
	{
		float move = 6*Time.deltaTime;
		transform.Translate(new Vector3(move,0,0));
		//rb2d.AddForce(Vector2.right*speed*Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.CompareTag("knight"))
		{
			kh = col.gameObject.GetComponent<KnightsHealth>();
			if(kh != null)
			{
				StopCoroutine(DestroySelf());
				Destroy (gameObject);
				kh.health--;
			}	
			if(kh.health <= 0)
			{
				StopCoroutine(DestroySelf());
				Destroy (gameObject);
				asource.Play();
				Destroy (col.gameObject);
				Instantiate(BloodSplatter,col.transform.position,Quaternion.identity);
				gv.KnightsKilled++;
				gv.KnightsLeft--;
				//gv.numSpawned--;
				//Debug.Log("inside MoveFireball "+(gv.KnightsLeft - gv.numSpawned));
			}

		}
	}

	IEnumerator DestroySelf()
	{
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);

	}

}
