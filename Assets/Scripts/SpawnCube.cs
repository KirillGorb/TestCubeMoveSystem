using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private Transform _spawnPositionCube;

    [SerializeField] private float _timeRespawn;

    public void SetTimer(InputField inputField)
    {
        _timeRespawn =Math.Abs( Convert.ToInt16(inputField.text));
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timeRespawn);

            Instantiate(_cube, _spawnPositionCube.position, Quaternion.identity);
        }
    }
}