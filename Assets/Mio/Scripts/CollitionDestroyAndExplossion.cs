using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDestroyAndExplossion : MonoBehaviour
{

	public GameObject explosion;
    public string nameObjetoQueToco;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == this.nameObjetoQueToco)
        {
			this.gameObject.GetComponent<Rigidbody>().AddForce(0,500,0);
			Destroy(other.gameObject);

			GameObject explosion = Instantiate(this.explosion, transform.position, Quaternion.identity);
			Destroy(explosion,1);
        }
    }

}
