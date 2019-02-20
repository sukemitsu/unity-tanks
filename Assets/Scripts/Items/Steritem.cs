using UnityEngine;

public class Steritem: MonoBehaviour
{
    public GameObject effectPrefab;
    private TankHealth th;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            th = other.gameObject.GetComponent<TankHealth>();
            th.Muteki();
            Destroy(gameObject);
            GameObject effect = (GameObject)Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.7f);
        }
    }
}