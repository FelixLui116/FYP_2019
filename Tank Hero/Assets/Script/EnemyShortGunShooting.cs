using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShortGunShooting : MonoBehaviour {

	//This script is the shortgun enemy shooting and AI system
    public Vector3 bulletOffset = new Vector3(0, 0f, 0);

    public GameObject bulletPrefab;
    public GameObject targetPlayer;
    public GameObject FirePoint1;
	public GameObject FirePoint2;
	public GameObject FirePoint3;
	public GameObject FirePoint4;
	public GameObject FirePoint5;
	public GameObject FirePoint6;

    public AudioSource enemyShootSound;
    

    public PlayerInTree InTree;

    int bulletLayer;
    public float fireDelay = 4f;
    float cooldownTimer = 0;

    public float moveSpeed;
    public float rotationSpeed;

    void Start()
    {
        bulletLayer = gameObject.layer;

        enemyShootSound = GetComponent<AudioSource>();

        InTree = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInTree>();
    }

    // Update is called once per frame
    void Update()
    {
        // https://www.youtube.com/watch?v=rhoQd6IAtDo
        //discovery the player
        if(InTree.playerInTree == false)
        {
        if(Vector2.Distance(transform.position, targetPlayer.transform.position) <17)
        {
            if(Vector2.Distance(transform.position, targetPlayer.transform.position) > 10)
            {

            transform.position = Vector3.MoveTowards(transform.position, targetPlayer.transform.position, moveSpeed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, targetPlayer.transform.position, moveSpeed * Time.deltaTime);
            Vector3 vectorToTarget = targetPlayer.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);

            }

            if(Vector2.Distance(transform.position, targetPlayer.transform.position) <10)
            {
                Vector3 vectorToTarget = targetPlayer.transform.position - transform.position;
                float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
                Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);


                cooldownTimer -= Time.deltaTime;
                if (cooldownTimer <= 0)
                {
            
                cooldownTimer = fireDelay;

                enemyShootSound.Play();

				Vector3 offset2 = transform.rotation * bulletOffset;
           		GameObject bulletGO2 = (GameObject)Instantiate(bulletPrefab, FirePoint2.transform.position + offset2, FirePoint2.transform.rotation);
            	bulletGO2.layer = bulletLayer;

				Vector3 offset1 = transform.rotation * bulletOffset;
            	GameObject bulletGO1 = (GameObject)Instantiate(bulletPrefab, FirePoint1.transform.position + offset1, FirePoint1.transform.rotation);
            	bulletGO1.layer = bulletLayer;

				Vector3 offset3 = transform.rotation * bulletOffset;
            	GameObject bulletGO3 = (GameObject)Instantiate(bulletPrefab, FirePoint3.transform.position + offset3, FirePoint3.transform.rotation);
            	bulletGO3.layer = bulletLayer;
				
				Vector3 offset4 = transform.rotation * bulletOffset;
            	GameObject bulletGO4 = (GameObject)Instantiate(bulletPrefab, FirePoint4.transform.position + offset4, FirePoint4.transform.rotation);
            	bulletGO4.layer = bulletLayer;


				Vector3 offset5 = transform.rotation * bulletOffset;
            	GameObject bulletGO5 = (GameObject)Instantiate(bulletPrefab, FirePoint5.transform.position + offset5, FirePoint5.transform.rotation);
            	bulletGO5.layer = bulletLayer;
                
				Vector3 offset6 = transform.rotation * bulletOffset;
            	GameObject bulletGO6 = (GameObject)Instantiate(bulletPrefab, FirePoint6.transform.position + offset6, FirePoint6.transform.rotation);
            	bulletGO6.layer = bulletLayer;
				}
             
            }
            }
        }   
    }
}
