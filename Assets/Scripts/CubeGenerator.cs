using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    private float _requiredDistance = 10f;
    private float _cubeSpeed = 2;
    private float _spawnTime = 1f;
    [SerializeField] private GameObject _cubePrefab;
    void Start()
    {
        StartCoroutine(SpawnTimer(_spawnTime));
    }
    public void ChangeCubeSpeed(float speed)
    {
        _cubeSpeed = speed;
        Debug.Log("Speed: " + _cubeSpeed);
    }
    public void ChangeRequiredDistance(float distance)
    {
        _requiredDistance = distance;
        Debug.Log("Distance: " + _requiredDistance);
    }
    public void ChangeSpawnTime(float time)
    {
        _spawnTime = time;
        Debug.Log("Spawn Time: " + _spawnTime);
    }
    private IEnumerator SpawnTimer(float time)
    {
        yield return new WaitForSeconds(time);
        SpawnCube();
        StartCoroutine(SpawnTimer(_spawnTime));
    }
    private void SpawnCube()
    {
        GameObject cube = Instantiate(_cubePrefab, Vector3.zero, Quaternion.identity);
        cube.GetComponent<CubeMoving>().SetParams(_cubeSpeed, _requiredDistance);
    }
}
