using UnityEngine;

public class PlayerStorage 
{
    private GameObject _currentPlayer;
    private GameObject _playerCamera;
    private PlayerFactory _playerFactory;
    public GameObject GetCurrentPlayer() => _currentPlayer;
    public GameObject GetCurrentPlayerCamera() => _playerCamera;

    public void Construct(PlayerFactory playerFactory)
    {
        _playerFactory = playerFactory;
    }
    
    public void SetUp(CharacterData characterData)
    {
        var mass = _playerFactory.CreatePlayer(characterData);
        _currentPlayer = mass[0];
        _playerCamera = mass[1];;
    }
    
    public void DestroyData()
    {
        if(_currentPlayer!=null)
            Object.Destroy(_currentPlayer);
        
        if(_playerCamera!=null)
            Object.Destroy(_playerCamera);
    }
    
}
