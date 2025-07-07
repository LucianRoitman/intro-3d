using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public int maxHealthPoints;
    public UiManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
        healthPoints = maxHealthPoints;
    }

    public void TakeDamage(int damagePoints)
    {
        if (healthPoints <= damagePoints)
        {
            return;
        }
        Debug.Log("Damage taken");
        healthPoints -= damagePoints;
        uiManager.UpdateHealth(healthPoints);
    }

}