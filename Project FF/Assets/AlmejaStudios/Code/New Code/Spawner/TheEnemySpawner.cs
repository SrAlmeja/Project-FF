using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemies;
    [SerializeField] int sizeEnemy;
    private int randomEnemy;
    private float randomx;
    private Vector3 spawnPosition;

    [SerializeField] private floatVariable dificult;

    private float elapsedTime;
    private int timeLimit;

    private void Awake()
    {
        randomEnemy = UnityEngine.Random.Range(0, _enemies.Length);
        elapsedTime = 0;
    }

    private void Start()
    {
        PoolingSystem.PreLoad(_enemies[randomEnemy], sizeEnemy);
    }

    private void FixedUpdate()
    {
        elapsedTime += Time.deltaTime;
        randomx = UnityEngine.Random.Range(-3,3);
        spawnPosition = new Vector3(randomx, 0, 18);
    }
}
