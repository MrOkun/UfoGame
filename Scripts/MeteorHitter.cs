using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorHitter : MonoBehaviour
{
    [SerializeField] private GameObject _effect;
    private GameObject Health;

    private void Start()
    {
        Health = GameObject.Find("Health");
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Explose();
            col.gameObject.GetComponent<PlayerHealth>().OnMeteorHitted();
            Health.GetComponent<HealthCount>().HealthUpdate();
            Destroy(this.gameObject);
        }
    }
    private void Explose()
    {
        Instantiate(_effect, this.gameObject.transform.position, Quaternion.identity);
    }
}
