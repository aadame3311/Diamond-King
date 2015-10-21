using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public int speed;
    public Transform target;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

	// Update is called once per frame
	void Update () {

        AI_movement();
	}

    void AI_movement() {

        //transform.position = transform.forward * speed * Time.deltaTime;
    }
}

