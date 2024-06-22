using UnityEngine;

public class SlideTrigger : MonoBehaviour
{
    [SerializeField]
    private SlideTrigger _nextTrigger;  // Ссылка на следующий триггер

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
