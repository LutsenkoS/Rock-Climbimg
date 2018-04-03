using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float Torque = 150f;
    public float Acceleration = 100f;
   
    public Transform Handle;
    public Transform Body;

    private float _angle;
    private float _moveHor;
    private float _moveVer;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _moveHor = Input.GetAxis("Horizontal");
        _moveVer = Input.GetAxis("Vertical");
        if (_moveHor != 0 || _moveVer != 0)
        {                       
            Vector3 angle = Vector3.Cross(transform.position - Body.position, new Vector3(_moveHor, _moveVer));
            Handle.GetComponent<Rigidbody>().AddTorque(angle * Torque);
        }
    }   
    private void OnCollisionEnter(Collision other)
    {        
        Torque += Acceleration;
    }

    private void OnCollisionExit(Collision other)
    {
        Torque -= Acceleration;
    }
    
}
