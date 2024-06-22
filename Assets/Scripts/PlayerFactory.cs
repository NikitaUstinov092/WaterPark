using UnityEngine;

public class PlayerFactory : MonoBehaviour
{
   [SerializeField] 
   private Transform _startPoint;
   
   public void CreatePlayer(CharacterData characterData)
   {
      var position = _startPoint.position;
      Instantiate(characterData.Character, position, Quaternion.identity);
      Instantiate(characterData.Camera, position, Quaternion.identity);
   }
}
