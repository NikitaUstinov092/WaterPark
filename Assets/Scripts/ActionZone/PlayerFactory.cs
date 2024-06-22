using UnityEngine;

public class PlayerFactory : MonoBehaviour
{
   [SerializeField] 
   private Transform _startPoint;
   
   private PlayerStorage _playerStorage;

   public void Construct(PlayerStorage playerStorage)
   {
      _playerStorage = playerStorage;
   }
   
   public void CreatePlayer(CharacterData characterData)
   {
      var position = _startPoint.position;
      var player =  Instantiate(characterData.Character, position, Quaternion.identity);
      var playerCamera =  Instantiate(characterData.Camera, position, Quaternion.identity);
      
      _playerStorage.SetUp(player,playerCamera);
   }
}
