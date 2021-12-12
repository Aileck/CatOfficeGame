using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agentscript : MonoBehaviour
{
    //[SerializeField] 
    private NavMeshAgent agent;
    public GameObject spawnerr ;
    public GameObject target;
    float time = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        target = spawnerr.GetComponent<Spawner>().playerref;
        var agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = spawnerr.GetComponent<Spawner>().playerref;
        time -= Time.deltaTime;
        if (time < 0)
        {
            agent.SetDestination(target.transform.position);
        }
     }
}
