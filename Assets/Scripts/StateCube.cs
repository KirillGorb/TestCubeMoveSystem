using UnityEngine;
using UnityEngine.UI;
using System;

public class StateCube : MonoBehaviour
{
    [SerializeField] private float _moveDistancy;
    [SerializeField] private float _speed;

    public void SetSpeed(InputField inputField)
    {
        _speed = Convert.ToInt16(inputField.text);
    }
    public void SetDistancy(InputField inputField)
    {
        _moveDistancy = Convert.ToInt16(inputField.text);
    }

    public void MoveCube(Transform transform) => transform.Translate(Vector3.right * _speed * Time.deltaTime);

    public void DestroyCube(Vector3 startPos, GameObject obj)
    {
        if (Vector3.Distance(startPos, obj.transform.position) >= _moveDistancy)
        {
            Destroy(obj);
        }
    }
}