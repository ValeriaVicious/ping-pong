using UnityEngine;


namespace ThePingPong
{
    internal sealed class MoveRacket : MonoBehaviour
    {
        #region Fields

        [SerializeField] private string _chooseAxisForTheRacket = "Vertical";
        [SerializeField] private float _speed = 30.0f;

        private Rigidbody2D _rigidBody;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            MoveTheRacket();
        }

        #endregion


        #region Methods

        private void MoveTheRacket()
        {
            float verticalVector = Input.GetAxisRaw(_chooseAxisForTheRacket);
            _rigidBody.velocity = new Vector2(0.0f, verticalVector) * _speed;
        }

        #endregion
    }
}

