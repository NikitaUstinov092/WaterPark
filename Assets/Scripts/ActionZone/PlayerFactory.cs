using UnityEngine;

public class PlayerFactory : MonoBehaviour
{
   [SerializeField] 
   private Transform _startPoint;

   public GameObject[] CreatePlayer(CharacterData characterData)
   {
      var position = _startPoint.position;
      var player =  Instantiate(characterData.Character, position, Quaternion.identity);
      var playerCamera =  Instantiate(characterData.Camera, position, Quaternion.identity);

      return new [] {player, playerCamera};
   }

   public SlideForce CreateDoll(GameObject doll, Transform startPoint)
   {
      var go = Instantiate(doll, startPoint.position, startPoint.rotation);
      return go.GetComponentInChildren<SlideForce>();
   }
}
