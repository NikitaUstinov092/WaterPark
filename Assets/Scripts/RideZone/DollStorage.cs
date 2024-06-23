using UnityEngine;

    public class DollStorage
    {
        public SlideForce CurrentDoll { get; private set; }

        private PlayerFactory _playerFactory;
        
        public void Construct(PlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }
        public void SetUp(GameObject doll, Transform point)
        {
            CurrentDoll = _playerFactory.CreateDoll(doll, point);
        }
        public void DestroyData()
        {
            if (CurrentDoll!=null)
            {
                Object.Destroy(CurrentDoll.transform.root.gameObject);
            }
        }
    }
