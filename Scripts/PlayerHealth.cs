using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    private int health;

    private void Start()
    {
        health = maxHealth;
    }

    public void OnMeteorHitted()
    {
        health -= 1;

        if (health < 0)
        {
            SceneManager.LoadScene("Over");
        }
        else
        {
            Debug.Log(health);
        }
    }

    public int GetHP()
    {
        return health;
    }

    public int GetMaxHP()
    {
        return maxHealth;
    }
}
