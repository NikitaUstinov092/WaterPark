using UnityEngine;

public class DollData : MonoBehaviour, IRideable
{
    [SerializeField] 
    private GameObject _doll;

    public GameObject GetDoll() => _doll;
}


public interface IRideable
{
    GameObject GetDoll();
}



