using Sirenix.OdinInspector;
using UnityEngine;

public class SelectedCharacterStorage : MonoBehaviour
{
    [SerializeField] 
    private CharacterData[] _characters;
    
    [SerializeField] 
    private CharacterIdStorage _characterIdStorage;

    [ShowInInspector, ReadOnly]
    public CharacterData SelectedCharacter { get; private set; }

    private void OnEnable()
    {
        _characterIdStorage.OnValueChanged += SelectCharacter;
    }
    private void OnDisable()
    {
        _characterIdStorage.OnValueChanged -= SelectCharacter;
    }
    private void SelectCharacter(int value)
    {
        SelectedCharacter = _characters[value];
    }
}
