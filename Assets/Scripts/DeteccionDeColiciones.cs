using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColiciones : MonoBehaviour
{
  void OnCollisionEnter(Collision col)
    {
        Debug.Log("contacto");
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
