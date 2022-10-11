using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private float _speed;
    private float _distance;
    private Vector3 _initialPosition;
    private Vector3 _direction;
    
    public void SetParams(float speed, float distance)
    {
        _direction = Vector3.forward;
        _speed = speed;
        _distance = distance;
        _initialPosition = transform.position;
        _rigidbody.AddForce(_direction * _speed, ForceMode.Force);
    }
    void FixedUpdate()
    {
        if (Vector3.Distance(_initialPosition, transform.position) >= _distance)
            Destroy(gameObject);
    }
}
