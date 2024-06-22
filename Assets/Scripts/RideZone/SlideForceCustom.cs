using UnityEngine;

public class SlideForceCustom : MonoBehaviour, ISetForceDirection
{
    [SerializeField]
    private float _forceMagnitude = 70f;
    
    [SerializeField]
    private Rigidbody rb;

    [SerializeField] 
    private Vector3 _forceDirection;

    void ISetForceDirection.SetDirection(Vector3 direction)
    {
        _forceDirection = direction;
    }
    
    private void FixedUpdate()
    {
        ApplyForce();
    }

    private void ApplyForce()
    {
        rb.AddForce(_forceDirection * _forceMagnitude);
    }

}

public interface ISetForceDirection
{
    void SetDirection(Vector3 direction);
}
