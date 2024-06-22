using UnityEngine;

public class Selector : MonoBehaviour
{
    [SerializeField]
    private CharacterIdStorage _characterIdStorage;

    public void MoveLeft()
    {
        _characterIdStorage.SetId(_characterIdStorage.currentId - 1);
    }
    
    public void MoveRight()
    {
        _characterIdStorage.SetId(_characterIdStorage.currentId + 1);
    }
}
