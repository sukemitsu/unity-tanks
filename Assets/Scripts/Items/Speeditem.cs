using System.Collections;
using UnityEngine;

public class Speeditem : MonoBehaviour
{
    public GameObject effectPrefab;
    private TankMovement tm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tm = other.gameObject.GetComponent<TankMovement>();
            tm.SpeedUp(2f);
            Destroy(gameObject);
            GameObject effect = (GameObject)Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.7f);
        }
    }
}