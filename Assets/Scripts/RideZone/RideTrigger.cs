using System;
using UnityEngine;

public class RideTrigger : MonoBehaviour
{
    public event Action<GameObject, Transform> OnCatchRideable;

    [SerializeField] 
    private Transform _spawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IRideable rideable))
        {
            OnCatchRideable?.Invoke( rideable.GetDoll(), _spawnPoint);
        }
    }
}
