using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{
	public Transform bumpSource;
	public float bumpForce = 100f;
	public bool removeOnBump = false; // Add later
	public int updateScore = 100;

	private void OnCollisionEnter(Collision collision)
	{
		Vector3 forceDir = (collision.rigidbody.position - bumpSource.position).normalized;

		collision.rigidbody.AddForce(forceDir * bumpForce, ForceMode.Impulse);

		GameScore.score += updateScore;

		
	}
}