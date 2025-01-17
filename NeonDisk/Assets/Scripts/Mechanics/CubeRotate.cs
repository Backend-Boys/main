﻿/*
* File:			CubeRotate.cs
* Author:		Duncan Sykes (s200490@students.aie.edu.au)
* Edit Dates:
*	First:		10/06/2021
*	Last:		18/06/2021
* Summary:
*	Used to rotate asteroids and other objects on all axis.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[SelectionBase]
public class CubeRotate : MonoBehaviour
{
    public float mult = 3;

    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("NPC"))
        {
            _transform.Rotate(0.1f * mult, 0.01f * mult, 0.1f * mult, Space.World);
        }
        else
        {
            _transform.Rotate(0.01f * mult, 0.01f * mult, 0.01f * mult, Space.World);
        }
    }
}
