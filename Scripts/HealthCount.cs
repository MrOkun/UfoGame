using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HealthCount : MonoBehaviour
{
    private Text HealthText;
    private PlayerHealth Player;
    private int PlayerMaxHealth;

    private void Start()
    {
        Player = GameObject.Find("UFO").GetComponent<PlayerHealth>();
        HealthText = GetComponent<Text>();
        PlayerMaxHealth = Player.GetMaxHP();
        HealthText.text = "100%";
    }

    public void HealthUpdate()
    {
        HealthText.text = (Mathf.CeilToInt(100 / PlayerMaxHealth * Player.GetHP()) + 1).ToString() + "%";
    }
}
