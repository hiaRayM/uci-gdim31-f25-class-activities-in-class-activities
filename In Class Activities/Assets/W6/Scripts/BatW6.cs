using System;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;

    private Transform _catTransform;
    private bool _isChasing = false;

    private void Start()
    {
        _catTransform = GameObject.Find("Cat").transform;
        StartChase();
    }

    private void Update()
    {
        if (_isChasing && _catTransform != null)
        {
            Vector3 dir = (_catTransform.position - transform.position).normalized;
            transform.position += dir * _speed * Time.deltaTime;
        }
    }

    public void StartChase()
    {
        _isChasing = true;
    }

    public void StopChase()
    {
        _isChasing = false;
    }
}
