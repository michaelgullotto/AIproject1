using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform[] waypoint;
    public int currentWaypoint = 0;
    public float speed = 10f;
    public bool isRandomWaypoint = false;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, waypoint[currentWaypoint].position, step);

        if (Vector3.Distance(transform.position, waypoint[currentWaypoint].position) < 0.1f)
        {
            currentWaypoint++;
        }
        if (currentWaypoint >= waypoint.Length)
        {
            currentWaypoint = 0;
        }



    }
}
