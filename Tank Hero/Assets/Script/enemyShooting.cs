using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemyShooting : MonoBehaviour
{

    //This script is the enemy shooting and AI system
    public Vector3 bulletOffset = new Vector3(0, 0f, 0);

    public GameObject bulletPrefab;
    public GameObject targetPlayer;
    public GameObject FirePoint;

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
        InTree = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInTree>();

        enemyShootSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(InTree.playerInTree == false)
        {
        // https://www.youtube.com/watch?v=rhoQd6IAtDo
        //discovery the player
            if(Vector2.Distance(transform.position, targetPlayer.transform.position) <17)
            {
            if(Vector2.Distance(transform.position, targetPlayer.transform.position) > 7)
                {
                transform.position = Vector3.MoveTowards(transform.position, targetPlayer.transform.position, moveSpeed * Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position, targetPlayer.transform.position, moveSpeed * Time.deltaTime);
                Vector3 vectorToTarget = targetPlayer.transform.position - transform.position;
                float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
                Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);

                }

                if(Vector2.Distance(transform.position, targetPlayer.transform.position) < 7)
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

                    Vector3 offset = transform.rotation * bulletOffset;
                    GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, FirePoint.transform.position + offset, FirePoint.transform.rotation);
                    bulletGO.layer = bulletLayer;
                    }
                }
         }   
        }
    }
}








    //Vector3 targetDir = targetPlayer.transform.position - transform.position;
    //float step = speed * Time.deltaTime;

    //Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
    //float angle = Vector3.Angle(targetDir, transform.forward);
    //transform.rotation = Quaternion.LookRotation(newDir);
    //if (angle < 3.0f)
    //{
    //    lockOn = true;
    //}






    //Vector3 difference = targetPlayer.position - transform.position;
    //difference.Normalize();

    //float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
    //transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);

        //private float timeShots;
        //public float startShots;

        //private Transform player;

        //public GameObject enemyBullet;

        //void Start()
        //{
        //    player = GameObject.FindGameObjectWithTag("Player").transform;

        //    timeShots = startShots;

        //}

        //void Update()
        //{


        //    if (timeShots <= 0)
        //    {
        //        Instantiate(enemyBullet, transform.position, Quaternion.identity);
        //    }
        //    else
        //    {
        //        timeShots -= Time.deltaTime;
        //    }

        //}