using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColiciones : MonoBehaviour
{
  void OnCollisionEnter()
    {
        Debug.Log("acto acto pide contacto quiere que lo hagamos cada rato, duro dos horas haciendolo bien rico o de las chicas soy su favorito o");
        Destroy(gameObject);
    }
}
