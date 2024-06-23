using UnityEngine;

public class SlideForce : MonoBehaviour, ISetForceDirection
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

    public void SetMagnitude(float value)
    {
        _forceMagnitude = value;
    }
    
    private void FixedUpdate()
    {
        ApplyForce();
    }

    private void ApplyForce()
    {
        if(_forceMagnitude<=0)
            return;
        
        rb.AddForce(_forceDirection * _forceMagnitude);
    }

}

public interface ISetForceDirection
{
    void SetDirection(Vector3 direction);
}
