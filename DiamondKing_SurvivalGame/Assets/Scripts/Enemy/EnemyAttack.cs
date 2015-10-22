using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;

    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    bool playerInRange;
    float timer;

    public Transform target;
    public float dist;
    public int speed;

	// Use this for initialization
	void Awake () {

        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        //anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            Attack();
        }

        
	}

    void Attack()
    {
        if (Vector2.Distance(transform.position, target.position) > dist)
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0));
        }
    }


}
