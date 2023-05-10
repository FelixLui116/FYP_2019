using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	// set the enemy collider the bullet, get the player exp and score
	public int health;
	public float invulnPeriod = 0;

	public GameObject DestoryObject;

	public GameObject Explosion;

	//public float ExplosionTimer = 1;

	private PlayerLevel playerLevelClass;
	private EnemyCount enemyCount;

	float invulnTimer = 0;
	int correctLayer;

	SpriteRenderer spriteRend;

	void Start() {
		correctLayer = gameObject.layer;

		// NOTE!  This only get the renderer on the parent object.
		// In other words, it doesn't work for children. I.E. "enemy01"
		playerLevelClass = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLevel>();
		enemyCount = GameObject.FindGameObjectWithTag("LevelBlock").GetComponent<EnemyCount>();
		

		spriteRend = GetComponent<SpriteRenderer>();

		if(spriteRend == null) {
			spriteRend = transform.GetComponentInChildren<SpriteRenderer>();

			if(spriteRend==null) {
				Debug.LogError("Object '"+gameObject.name+"' has no sprite renderer.");
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "bullet2")
		{
			//print("Enemy Hit");
			health-=1;

			FloatTextEnemy floatTextEnemy = gameObject.GetComponent<FloatTextEnemy>();

			floatTextEnemy.SpawnText ();

			//print(health);
		}
		
		if(invulnPeriod > 0) {
			invulnTimer = invulnPeriod;
			gameObject.layer = 10;
		}
	}

	void Update() {

		if(health <= 0) {
			//print("<=0");
			// player get score
			//ExplosionTimer -= Time.deltaTime;
			enemyCount.enemyKilled +=1;
			ScoreScipt.scoreValue += 100;
			playerLevelClass.playerExp +=2;
			print(playerLevelClass.playerExp);

			Instantiate(Explosion, transform.position, transform.rotation);

			Die();
		}

		if(invulnTimer > 0) {
			invulnTimer -= Time.deltaTime;

			if(invulnTimer <= 0) {
				gameObject.layer = correctLayer;
				if(spriteRend != null) {
					spriteRend.enabled = true;
				}
			}
			else {
				if(spriteRend != null) {
					spriteRend.enabled = !spriteRend.enabled;
				}
			}
		}

		
	}

	void Die() 
	{
			Destroy(DestoryObject);
		//Destroy(DestoryObject);
	}

}
