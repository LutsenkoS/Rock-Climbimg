using UnityEngine;

public class CameraController : MonoBehaviour{

    public Transform target;

    private Vector3 _offset;
    void Start()
    {
        _offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        transform.position = target.position + _offset + new Vector3(0f, 3f, 0f);
    }
}
