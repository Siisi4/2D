using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public GameObject drapeau;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 contactPoint = collision.GetContact(0).point;
        contactPoint.z = -5;

        // on va instancier le drapeau en un point donné.
        Instantiate(drapeau, contactPoint, Quaternion.identity);
    }



}
