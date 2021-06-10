using UnityEngine;
using UnityEngine.UI;

namespace ThePingPong
{
    internal sealed class Ball : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Text _leftPlayerScoreText;
        [SerializeField] private Text _rightPlayerScoreText;
        [SerializeField] private float _speed = 15.0f;
        [SerializeField] int _score = 1;
        [SerializeField] private int _maxCount = 5;

        private Rigidbody2D _rigidbody;
        private int _leftScore;
        private int _rightScore;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            MoveTheBall();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            CheckTheCollision(collision);
        }

        #endregion


        #region Methods

        private void MoveTheBall()
        {
            _rigidbody.velocity = Vector2.right * _speed;
        }

        private float HitFactor(Vector2 ballPosition, Vector2 racketPosition,
            float racketHeight)
        {
            return (ballPosition.y - racketPosition.y) / racketHeight;
        }

        private void CheckTheCollision(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(Constants.LeftRacketTag))
            {
                float y = HitFactor(transform.position,
                    collision.transform.position, collision.collider.bounds.size.y);
                Vector2 direction = new Vector2(1.0f, y).normalized;
                _rigidbody.velocity = direction * _speed;
            }
            if (collision.gameObject.CompareTag(Constants.RightRacketTag))
            {
                float y = HitFactor(transform.position,
                    collision.transform.position, collision.collider.bounds.size.y);
                Vector2 direction = new Vector2(-1.0f, y).normalized;
                _rigidbody.velocity = direction * _speed;
            }
            if (collision.gameObject.CompareTag(Constants.RightWall))
            {
                _leftScore += _score;
                _leftPlayerScoreText.text = _leftScore.ToString();
            }
            if (collision.gameObject.CompareTag(Constants.LeftWall))
            {
                _rightScore += _score;
                _rightPlayerScoreText.text = _rightScore.ToString();
            }
        }

        #endregion
    }
}
