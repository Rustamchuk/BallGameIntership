﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    public Transform StartPoint => _startPoint;
    public Transform EndPoint => _endPoint;
}
