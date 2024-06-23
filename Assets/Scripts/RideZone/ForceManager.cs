using UnityEngine;
using UnityEngine.UI;

public class ForceManager : MonoBehaviour
{
   [SerializeField] 
   private Slider _slider;
   
   private DollStorage _dollStorage;

   public void Construct(DollStorage dollStorage)
   {
      _dollStorage = dollStorage;
   }
   private void OnEnable()
   {
      _slider.value = 0;
      var forceSlide = _dollStorage.CurrentDoll;
      forceSlide.SetMagnitude(_slider.value);
      _slider.onValueChanged.AddListener(forceSlide.SetMagnitude);
   }

   private void OnDisable()
   {
      _slider.onValueChanged.RemoveListener( _dollStorage.CurrentDoll.SetMagnitude);
   }
}
