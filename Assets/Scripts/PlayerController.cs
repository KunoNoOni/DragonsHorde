using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed = 10.0F;
	public GameObject fireball;

	AudioSource asource;

	//Animator anim;

	void Start () 
	{
		Physics2D.gravity = Vector3.zero;
		asource = GetComponent<AudioSource>();
		//anim = GetComponent<Animator>();
		//anim.SetBool("IsShooting", false);
		//anim.Play("Idle");
	}
	
	void Update () 
	{
		if(Input.GetAxis("Vertical") !=0)
		{
			transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0));
		}
		if(Input.GetKeyDown(KeyCode.C) || Input.GetButtonDown("Fire1"))
		{
			asource.Play();
			Instantiate(fireball,new Vector3(transform.position.x+3.2f,transform.position.y-.45f,transform.position.z),Quaternion.identity);
			//StartCoroutine(ShootFireball());
		}
    }

	//IEnumerator ShootFireball()
	//{
	//	yield return new WaitForSeconds(1f);
	//	//Instantiate(fireball,new Vector3(transform.position.x+3.2f,transform.position.y-.45f,transform.position.z),Quaternion.identity);
	//}
}
