using UnityEngine;

public class HPitem : MonoBehaviour
{
    public GameObject effectPrefab;
    private TankHealth th;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            th = other.gameObject.GetComponent<TankHealth>();
            th.AddHP(50);
            th.SetHealthUI();
            Destroy(gameObject);
            GameObject effect = (GameObject)Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.7f);
        }
    }
}