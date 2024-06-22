using System;
using UnityEngine;

public class Mediator : MonoBehaviour
{
    [SerializeField] 
    private PlayerFactory _playerFactory;
    
    [SerializeField] 
    private ViewManager _viewManager;
    private void Awake()
    {
      var playerStorage = new PlayerStorage();
      _playerFactory.Construct(playerStorage);
      _viewManager.Construct(playerStorage);
    }
    
    
}
