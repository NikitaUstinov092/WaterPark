using UnityEngine;

public class TriggerWater : MonoBehaviour
{
   private const float DRAG = 8f;
   private void OnTriggerEnter(Collider other)
   {
      if (!other.TryGetComponent(out Rigidbody rb)) 
         return;
      rb.drag = DRAG;
   }
}
