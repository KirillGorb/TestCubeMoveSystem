using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private Transform _spawnPositionCube;

    [SerializeField] private float _timeRespawn;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    public void SetTimer(InputField inputField)
    {
        _timeRespawn = Math.Abs(Convert.ToInt16(inputField.text));
    }


    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timeRespawn);
            print(_timeRespawn);
            Instantiate(_cube, _spawnPositionCube.position, Quaternion.identity);
        }
    }
}