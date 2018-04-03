using UnityEngine;

public class CameraController : MonoBehaviour{

    public Transform target;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        transform.position = target.position + offset + new Vector3(0f, 3f, 0f);
    }
}
