using System;
using UnityEngine;

public class CharacterIdStorage : MonoBehaviour
{
    public event Action<int> OnValueChanged;

    [SerializeField] 
    private int[] _characterId;

    [field: SerializeField]
    public int currentId { get; private set; }
    
    private void Start()
    {
        OnValueChanged?.Invoke(currentId);
    }

    public void SetId(int value)
    {
        if(value < 0 || value >=_characterId.Length)
            return;
        
        currentId = value;
        OnValueChanged?.Invoke(currentId);
    }
}
