using UnityEngine;
using System.Collections;
using System;

public class TransformFollower : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    private void Update()
    {
        Refresh();
    }


    public void Refresh()
    {
        if (target == null)
        {
            Debug.LogWarning("Missing target ref !", this);
            return;
        }

		float velocidad = 1 * Time.deltaTime;
        Vector3 offset = Vector3.Scale(target.position - transform.position, new Vector3(velocidad,velocidad,velocidad));
		transform.position += offset;
    }
}