using UnityEngine;
using System.Collections;

public class playerShooting : MonoBehaviour {

	// Use this for initialization
	public Vector3 bulletOffset = new Vector3(0, 0f, 0);

	public GameObject bulletPrefab;
	int bulletLayer;

	public AudioSource playerShootSound;

	// set the shoot system, leftkey to shoot the bulletGO
	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	void Start() {
		bulletLayer = gameObject.layer;
		playerShootSound = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		cooldownTimer -= Time.deltaTime;

		if( Input.GetButton("Fire1") && cooldownTimer <= 0 ) {
			// SHOOT!
			Debug.Log("Enter leftkey");
			cooldownTimer = fireDelay;
			
			playerShootSound.Play();


			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = bulletLayer;
		}
		

	}
}
