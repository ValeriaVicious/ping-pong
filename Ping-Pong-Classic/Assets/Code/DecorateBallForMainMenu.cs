using UnityEngine;


namespace ThePingPong
{
    internal sealed class DecorateBallForMainMenu : MonoBehaviour
    {
        #region Fields

        private Rigidbody2D _rigidbody;
        private float _speed = 20.0f;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            MoveTheBall();
        }

        #endregion


        #region Methods

        private void MoveTheBall()
        {
            _rigidbody.velocity = Vector2.right * _speed;
        }

        #endregion
    }
}
