using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomitems : MonoBehaviour
{
    public GameObject[] Train;
    private int number;

    void Start()
    {
        number = Random.Range(0, Train.Length);
        Instantiate(Train[number], transform.position, transform.rotation);
    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}