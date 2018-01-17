using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProsteSterowanie : MonoBehaviour
{
	public float speed;
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
			transform.Translate( speed, 0, 0 );	
		}
		if( Input.GetKey( "left" ) )
		{
			transform.Translate( -speed, 0, 0 );	
		}
	}
}
