using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

    Animator anim;
    PlayerMovement playerMovement;
    EnemyHealth enemyHealth;
    public int currentHealth;
    private Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.Space))
        {
           
        }
	}
}
