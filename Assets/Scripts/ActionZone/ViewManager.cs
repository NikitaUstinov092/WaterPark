using UnityEngine;
using UnityEngine.Events;

public class ViewManager : MonoBehaviour
{
    public UnityEvent OnSwitchViewOnDoll;
    
    private PlayerStorage _playerStorage;
    public void Construct(PlayerStorage playerStorage)
    {
        _playerStorage = playerStorage;
    }

    public void SwitchViewOnDoll()
    {
        _playerStorage.DestroyData();
        OnSwitchViewOnDoll?.Invoke();
    }
}
