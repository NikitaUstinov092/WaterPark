using UnityEngine;

public class SlideForce : MonoBehaviour
{
    public float forceMagnitude = 10f;  // Мощность силы, которую будем применять

    [SerializeField]
    private float _angle = 70f;
    
    [SerializeField]
    private Vector3 forceDirectionLookFront;
    
    [SerializeField]
    private Vector3 forceDirectionLookBack;

    [SerializeField] 
    private Transform _lookTarget;

    [SerializeField] 
    private Transform _pelvis;
    
    [SerializeField]
    private Rigidbody rb;

   
    
    private void FixedUpdate()
    {
        ApplyForce();
    }

    private void ApplyForce()
    {
        Vector3 forceDirection = DetermineForceDirection();
        
        Debug.Log(_pelvis.rotation.y );
        // Проверяем, не перевернут ли объект
        /*if (IsUpsideDown())
        {
            Debug.Log("Перевёртышь");
          //  forceDirection = -forceDirection; // Инвертируем направление силы, если объект перевернут
        }*/

        rb.AddForce(forceDirection * forceMagnitude);
    }

    private bool IsUpsideDown()
    {
        if(_pelvis.rotation.eulerAngles.y > 180)
        {
            return true;
        }

        return false;
    }

    private Vector3 DetermineForceDirection()
    {
        // Вектор от объекта к цели
        Vector3 toTarget = _lookTarget.position - rb.transform.position;
        
        toTarget.Normalize();

        // Направление, куда смотрит объект
        Vector3 forward = rb.transform.forward;

        // Угол между направлением взгляда объекта и вектором к цели
        var angle = Vector3.Angle(forward, toTarget);

        // Если объект смотрит в сторону цели (условно, если угол меньше 90 градусов)
        if (angle < _angle)
        {
           // Debug.Log("forceDirectionLookFront");
            return forceDirectionLookFront;
        }
        //Debug.Log("forceDirectionLookBack");
        
        return forceDirectionLookBack;
        
    }
    
}