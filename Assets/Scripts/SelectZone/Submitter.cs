using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Submitter : MonoBehaviour
{
    public UnityEvent<CharacterData> OnSubmit;
    
    [SerializeField]
    private SelectedCharacterStorage _selectedCharacterStorage;
    
    [SerializeField] 
    private Button _buttonSubmit;

    private void OnEnable()
    {
        _buttonSubmit.onClick.AddListener(Submit);
    }
    private void OnDisable()
    {
        _buttonSubmit.onClick.RemoveListener(Submit);
    }
    private void Submit()
    {
        OnSubmit?.Invoke(_selectedCharacterStorage.SelectedCharacter);
    }
}
