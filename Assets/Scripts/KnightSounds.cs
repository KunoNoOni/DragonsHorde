using UnityEngine;
using System.Collections;

public class KnightSounds : MonoBehaviour 
{
	public AudioClip death1;
	public AudioClip death2;

	AudioSource asource; 
	int soundToPlay;

	void Start()
	{
		asource = GameObject.Find("GameVariables").GetComponent<AudioSource>();
		soundToPlay = Random.Range(1,10);
		if(soundToPlay <= 5 )
			asource.clip = death1;
		else
			asource.clip = death2;
	}

//	void Update()
//	{
//		if(gameObject.GetComponent<KnightsHealth>().health <= 0)
//		{
//			PlayDeathSound();
//		}
//	}

	public void PlayDeathSound()
	{
		Debug.Log ("Playing "+asource.clip.name);
		asource.Play();
	}

}
