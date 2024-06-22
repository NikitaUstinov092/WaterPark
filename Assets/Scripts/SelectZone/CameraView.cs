using UnityEngine;

public class CameraView : MonoBehaviour
{
    [SerializeField] 
    private CharacterIdStorage _characterIdStorage;

    [SerializeField] 
    private GameObject[] _cameras;
    
    private void OnEnable()
    {
        _characterIdStorage.OnValueChanged += SwitchCamera;
    }
    
    private void OnDisable()
    {
        _characterIdStorage.OnValueChanged -= SwitchCamera;
    }
    
    private void SwitchCamera(int obj)
    {
        foreach (var cam in _cameras)
        {
            cam.SetActive(false);
        }
        
        _cameras[obj].SetActive(true);
    }
}
