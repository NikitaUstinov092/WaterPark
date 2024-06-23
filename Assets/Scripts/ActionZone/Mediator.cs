using UnityEngine;

public class Mediator : MonoBehaviour
{
    [SerializeField] 
    private PlayerFactory _playerFactory;
    
    [SerializeField] 
    private StateManager stateManager;

    [SerializeField] 
    private Adapter _adapter;
    
    [SerializeField] 
    private ForceManager _forceManager;
    
    private void Awake()
    {
      var playerStorage = new PlayerStorage();
      var dollStorage = new DollStorage();
      
      dollStorage.Construct(_playerFactory);
      playerStorage.Construct(_playerFactory);
      
      _adapter.Construct(dollStorage);
      stateManager.Construct(playerStorage, dollStorage);
      _forceManager.Construct(dollStorage);
    }
}
