using UnityEngine;
using System.Collections;

public class MoveForword : MonoBehaviour {

	public float maxSpeed;

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);

		pos += transform.rotation * velocity;

		transform.position = pos;
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag == "Enemy")
		{
			Destroy(gameObject);
		}
	}

}
