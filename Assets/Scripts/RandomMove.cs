using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMove : MonoBehaviour
{
	private NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponenet<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(A.destination, transform.position) < 3f)
		{
			float randomX = Random.Range (-10f, 10f);
			float randomZ = Random.Range (-10f, 10f);
			
			Vector3 randomPosition = new Vector3 (transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
			
			_agent.destination = randomPosition;
		}
    }
}
