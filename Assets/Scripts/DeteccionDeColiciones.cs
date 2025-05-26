using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColiciones : MonoBehaviour
{
    public ScoreManager ScoreManager;
    public MercaderiaScript mercaderiaScript;

     void Start()
    {
        ScoreManager = FindObjectOfType<ScoreManager>();
        mercaderiaScript = GetComponent<MercaderiaScript>();
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("contacto");
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            ScoreManager.addScore(mercaderiaScript.scorePoints);
        }
    }
}
