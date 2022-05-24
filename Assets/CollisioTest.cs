using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisioTest : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Debug.Log("Contacto");
    }
    void OnCollisionExit()
    {
        Debug.Log("Dejó de hacer Contacto");
    }
    void OnCollisionStay()
    {
        Debug.Log("Está haciendo Contacto");
    }
}
