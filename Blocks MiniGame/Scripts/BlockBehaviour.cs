using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    public GameObject       particleEffect;
    public PointsCounter    points;

    private void OnCollisionEnter()
    {
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        transform.SetParent(null);
        points.GainPoint();
    }
}
