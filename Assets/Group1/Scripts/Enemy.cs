using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 2f;
    private Vector3 _targetPosition;
    private float _spawnAreaRadius = 4f;
    
    private Vector3 RandomSpawnPoint => Random.insideUnitCircle * _spawnAreaRadius
    
    private void Start()
    {
        _targetPosition = RandomSpawnPoint;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
        if (transform.position == _targetPosition)
            _targetPosition = RandomSpawnPoint;
    }
}
