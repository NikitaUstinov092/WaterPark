using Sirenix.OdinInspector;
using UnityEngine;

public class SlideTrigger : MonoBehaviour
{
    [ShowInInspector, ReadOnly]
    private SlideTrigger _nextTrigger;  // Ссылка на следующий триггер

    public void Setup(SlideTrigger next)
    {
        _nextTrigger = next;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (_nextTrigger == null)
            return;

        if (!other.gameObject.TryGetComponent(out ISetForceDirection setForceDirectionComp)) 
            return;
        {
            Vector3 direction = (_nextTrigger.transform.position - transform.position).normalized;
            setForceDirectionComp.SetDirection(direction);
        }
    }
}
