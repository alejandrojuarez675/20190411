using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopiarMaterial : MonoBehaviour
{
    public string Piso;

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name != this.Piso)
        {
            this.transform.GetChild(0).GetComponent<Renderer>().material = other.gameObject.GetComponent<Renderer>().material;
        }
    }

}
