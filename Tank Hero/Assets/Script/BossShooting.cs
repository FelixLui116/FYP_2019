using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour {

    /// This script is the boss enemy shooting  and AI system

    public Vector3 bulletOffset = new Vector3(0, 0f, 0);

    public GameObject bulletPrefab;
    public GameObject targetPlayer;
    public GameObject FirePoint;
	public GameObject FirePoint1;
	public GameObject FirePoint2;
	public GameObject FirePoint3;
	
    public PlayerInTree InTree;

    public AudioSource enemyShootSound;
    
    int bulletLayer;
    public float fireDelay = 4f;

	public float fireDelay2 = 2f;

	float cooldownTimer2 = 0;
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
        if(InTree.playerInTree == false)
        {
            Vector3 vectorToTarget = targetPlayer.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);
            if(Vector2.Distance(transform.position, targetPlayer.transform.position) > 13)
            {

                transform.position = Vector3.MoveTowards(transform.position, targetPlayer.transform.position, moveSpeed * Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position, targetPlayer.transform.position, moveSpeed * Time.deltaTime);
                /* Vector3 vectorToTarget = targetPlayer.transform.position - transform.position;
                float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
                Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);
             */
            } 
            if(Vector2.Distance(transform.position, targetPlayer.transform.position) < 13)
            {
               /*  Vector3 vectorToTarget = targetPlayer.transform.position - transform.position;
                float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
                Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);

 */
                cooldownTimer -= Time.deltaTime;
		        cooldownTimer2 -= Time.deltaTime;
                if (cooldownTimer <= 0)
                {
                cooldownTimer = fireDelay;

                enemyShootSound.Play();

                Vector3 offset1 = transform.rotation * bulletOffset;
                GameObject bulletGO1 = (GameObject)Instantiate(bulletPrefab, FirePoint1.transform.position + offset1, FirePoint1.transform.rotation);
                bulletGO1.layer = bulletLayer;

			    Vector3 offset = transform.rotation * bulletOffset;
                GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, FirePoint.transform.position + offset, FirePoint.transform.rotation);
                bulletGO.layer = bulletLayer;
                }
                if (cooldownTimer2 <= 0)
                {
                cooldownTimer2 = fireDelay2;

                enemyShootSound.Play();

			    Vector3 offset2 = transform.rotation * bulletOffset;
                GameObject bulletGO2 = (GameObject)Instantiate(bulletPrefab, FirePoint2.transform.position + offset2, FirePoint2.transform.rotation);
                bulletGO2.layer = bulletLayer;

			    Vector3 offset3 = transform.rotation * bulletOffset;
                GameObject bulletGO3 = (GameObject)Instantiate(bulletPrefab, FirePoint3.transform.position + offset3, FirePoint3.transform.rotation);
                bulletGO3.layer = bulletLayer;
		        }
            }
        }  
     }
}
