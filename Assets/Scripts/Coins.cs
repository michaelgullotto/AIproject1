using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject agent1;
    public GameObject agent2;
    public GameObject agent3;
    public GameObject door;
    public static int coinCount = 1;

    // Update is called once per frame
    void Update()
    {
        if(coinCount >= 2)
        {
            Destroy(door.gameObject);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == agent1 | agent2 | agent3)
        {

            Destroy(collision.gameObject);
            coinCount = coinCount + 1;
        }

    }



}
