using UnityEngine;
using UnityEngine.Events;

public class Cube : MonoBehaviour
{
    [HideInInspector] public UnityEvent Move;
    [HideInInspector] public UnityEvent<Vector3, GameObject> Destroy;

    private StateCube cube;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void OnEnable()
    {
        cube = FindObjectOfType<StateCube>();

        Move.AddListener(cube.MoveCube);
        Destroy.AddListener(cube.DestroyCube);
    }

    void Update()
    {
        Move?.Invoke();
        Destroy?.Invoke(startPos, gameObject);
    }
}
