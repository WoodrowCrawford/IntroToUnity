﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float FlapForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("flap"))
        {
            _rigidbody.AddForce(new Vector3(0, FlapForce, 0), ForceMode.Impulse);
        }
        
    }
}
