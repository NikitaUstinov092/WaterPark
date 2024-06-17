using UnityEngine;

public class SlideForce : MonoBehaviour
{
    public float forceMagnitude = 10f;  // Мощность силы, которую будем применять
    
    [SerializeField]
    private Rigidbody rb;
    
    private void FixedUpdate()
    {
        ApplyForce();
    }

    private void ApplyForce()
    {
        // Применяем силу вниз по наклону горки
        Vector3 forceDirection = Vector3.forward;

        // Проверяем, есть ли наклон, чтобы применить силу в нужном направлении
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            forceDirection = Vector3.ProjectOnPlane(Vector3.down, hit.normal).normalized;
        }

        // Применяем силу к кукле
        rb.AddForce(forceDirection * forceMagnitude);
    }
}

