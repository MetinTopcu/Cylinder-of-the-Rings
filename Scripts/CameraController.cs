﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 5.0f;
    public static CameraController camcont;
    void Start()
    {
        camcont = this;
    }
}
