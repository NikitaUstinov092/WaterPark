using UnityEngine;

public class Adapter : MonoBehaviour
{
    [SerializeField] 
    private RideTrigger[] _rideTriggers;

    [SerializeField] 
    private StateManager _stateManager;

    private DollStorage _dollStorage;

    public void Construct(DollStorage dollStorage)
    {
        _dollStorage = dollStorage;
    }
    private void OnEnable()
    {
        SubscribeRideTriggers();
    }
    private void OnDisable()
    {
        UnSubscribeRideTriggers();
    }
    private void SubscribeRideTriggers()
    {
        foreach (var trigger in _rideTriggers)
        {
            trigger.OnCatchRideable += _dollStorage.SetUp;
            trigger.OnCatchRideable += _stateManager.Handle;
        }
    }
    private void UnSubscribeRideTriggers()
    {
        foreach (var trigger in _rideTriggers)
        {
            trigger.OnCatchRideable -= _dollStorage.SetUp;
            trigger.OnCatchRideable -= _stateManager.Handle;
        }
    }
}
