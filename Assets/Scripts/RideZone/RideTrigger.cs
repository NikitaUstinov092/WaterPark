using UnityEngine;

public class RideTrigger : MonoBehaviour
{
    [SerializeField]
    private ViewManager _playerStorage;

    [SerializeField] 
    private Transform _spawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IRideable rideable))
        {
           var doll = rideable.GetDoll();
           Instantiate(doll, _spawnPoint.position, _spawnPoint.rotation);
           _playerStorage.SwitchViewOnDoll();
        }
    }
}
