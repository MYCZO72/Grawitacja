using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProsteSterowanie : MonoBehaviour
{
	public float speed;
	public float accel;
	public float zwolnij;
	private Rigidbody2D rigidb;

	void Awake () 
	{
		rigidb = GetComponent<Rigidbody2D>();
	}

	IEnumerator zwalnianie()
	{
		yield return new WaitForSeconds( 0.1f );
	}

	void FixedUpdate ()
	{
		float ruch = Input.GetAxis ("Horizontal");

		if (ruch * rigidb.velocity.x < speed)
			rigidb.AddForce(Vector2.right * ruch * accel);

		if (Mathf.Abs (rigidb.velocity.x) > speed)
			rigidb.velocity = new Vector2(Mathf.Sign (rigidb.velocity.x) * speed, rigidb.velocity.y);

		if (ruch == 0) 
		{
			StartCoroutine( zwalnianie() );
			rigidb.velocity = new Vector2( 0f, rigidb.velocity.y );
		}

	}

	/*
	void Update ()
	{
		if( Input.GetKey( "up" ) )
		{
			transform.Translate( 0, speed, 0 );	
		}
		if( Input.GetKey( "down" ) )
		{
			transform.Translate( 0, -speed, 0 );	
		}

		if( Input.GetKey( "right" ) )
		{
			transform.Translate( speed*Time.deltaTime, 0, 0 );	
		}
		if( Input.GetKeyUp( "right" ) )
		{
			
		}
		if( Input.GetKey( "left" ) )
		{
			transform.Translate( -speed*Time.deltaTime, 0, 0 );	
		}
	}*/
}
