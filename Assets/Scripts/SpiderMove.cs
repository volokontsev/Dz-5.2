using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(0, _speed * Time.deltaTime, 0);
    }
}
