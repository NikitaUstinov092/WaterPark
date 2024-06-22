using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Submitter : MonoBehaviour
{
    public UnityEvent OnSubmit;
    
    [SerializeField]
    private SelectedCharacterStorage _selectedCharacterStorage;

    [SerializeField] 
    private PlayerFactory _playerFactory;

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
        _playerFactory.CreatePlayer(_selectedCharacterStorage.SelectedCharacter); 
       OnSubmit?.Invoke();
    }

}
