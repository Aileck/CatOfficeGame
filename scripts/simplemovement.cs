using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplemovement : MonoBehaviour
{
    public float speed = 5f;
    float velocity;
    float velocityy;
    public UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        velocityy = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        transform.Translate(new Vector2(velocity * speed, velocityy * speed));
    }
    void OnCollisionEnter2D(Collision2D id)
    {
        if (id.gameObject.tag == "Player")
        {
            Debug.Log("Player hit");
        }
    }
}
