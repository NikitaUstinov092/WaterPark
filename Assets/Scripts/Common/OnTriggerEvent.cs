using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
   public UnityEvent OnTriggerEnterEvent;

   [SerializeField] 
   private string _tag;
   
   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag(_tag))
       {
           OnTriggerEnterEvent?.Invoke();
       }
   }
}
