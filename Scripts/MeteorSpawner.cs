using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField] private Transform Spawner;
    [SerializeField] private GameObject[] Meteors;

    private void Start()
    {
        StartCoroutine(IERepeat());
    }

    private void Repeat()
    {
        Instantiate(Meteors[Random.Range(0, Meteors.Length)], new Vector3(11, Random.Range(-3.2f, 3.2f), 0), Quaternion.AngleAxis(Random.Range(0, 360), new Vector3(1, 0, 0)));
        StartCoroutine(IERepeat());
    }

    IEnumerator IERepeat()
    {
        yield return new WaitForSeconds(1.8f);
        Repeat();
    }
}
