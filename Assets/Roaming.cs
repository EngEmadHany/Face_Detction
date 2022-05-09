using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roaming : MonoBehaviour
{
    public GameObject Turret;

    public Vector3 axis;

    public float angle;


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Turret.transform.position, axis, angle);
    }
}
