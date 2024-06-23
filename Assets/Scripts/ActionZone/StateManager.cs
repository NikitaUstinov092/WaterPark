using UnityEngine;
using UnityEngine.Events;

public class StateManager : MonoBehaviour
{
    public UnityEvent OnSwitchViewOnSelected;
    public UnityEvent OnSwitchViewOnDoll;
    public UnityEvent OnSwitchViewOnPlayer;

    [SerializeField] 
    private Submitter _submitter;
    
    private PlayerStorage _playerStorage;
    private DollStorage _dollStorage;

    public void Construct(PlayerStorage playerStorage, DollStorage dollStorage)
    {
        _playerStorage = playerStorage;
        _dollStorage = dollStorage;
    }
    
    public void SwitchOnSelected()
    {
        _playerStorage.DestroyData();
        _dollStorage.DestroyData();
        OnSwitchViewOnSelected?.Invoke();
    }
    
    private void SwitchViewOnDoll()
    {
        _playerStorage.DestroyData();
        OnSwitchViewOnDoll?.Invoke();
    }
    private void SwitchViewOnPlayer()
    {
        _dollStorage.DestroyData();
        OnSwitchViewOnPlayer?.Invoke();
    }
    
    private void Start()
    {
        SwitchOnSelected();
        _submitter.OnSubmit.AddListener(OnSubmit);
    }
    private void OnDestroy()
    {
        _submitter.OnSubmit.RemoveListener(OnSubmit);
    }

    private void OnSubmit(CharacterData data)
    {
        _playerStorage.SetUp(data);
        SwitchViewOnPlayer();
    }

    public void Handle(GameObject arg1, Transform arg2)
    {
        SwitchViewOnDoll();
    }
}
