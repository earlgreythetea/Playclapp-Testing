using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private CubeGenerator _cubeGenerator;
    [SerializeField] private TMPro.TMP_InputField _cubeSpeedInput;
    [SerializeField] private TMPro.TMP_InputField _requiredDistanceInput;
    [SerializeField] private TMPro.TMP_InputField _spawnTimerInput;

    public void ChangeCubeSpeed()
    {
        float speed = float.Parse(_cubeSpeedInput.text);
        _cubeGenerator.ChangeCubeSpeed(speed);
    }
    public void ChangeRequiredDistance()
    {
        float distance = float.Parse(_requiredDistanceInput.text);
        _cubeGenerator.ChangeRequiredDistance(distance);
    }
    public void ChangeSpawnTime()
    {
        float spawnTime = float.Parse(_spawnTimerInput.text);
        _cubeGenerator.ChangeSpawnTime(spawnTime);
    }
}
