using UnityEngine;

public class PlayerStorage 
{
    private GameObject _currentPlayer;
    private GameObject _playerCamera;

    public GameObject GetCurrentPlayer() => _currentPlayer;
    public GameObject GetCurrentPlayerCamera() => _playerCamera;
    public GameObject[] GetCurrentData()=> new GameObject[2]{_currentPlayer,_playerCamera};
    
    public void SetUp(GameObject currentPlayer, GameObject playerCamera)
    {
        _currentPlayer = currentPlayer;
        _playerCamera = playerCamera;
    }
    
    public void DestroyData()
    {
        if(_currentPlayer!=null)
            Object.Destroy(_currentPlayer);
        
        if(_playerCamera!=null)
            Object.Destroy(_playerCamera);
    }
    
}
