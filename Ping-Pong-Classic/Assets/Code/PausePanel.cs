using System;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace ThePingPong
{
    internal sealed class PausePanel : MonoBehaviour
    {
        #region Fields

        [SerializeField] private GameObject _panelPause;
        private static bool _isPausedGame = false;

        #endregion


        #region UnityMethods

        private void Update()
        {
            CheckThePause();
        }

        #endregion


        #region Methods

        private void CheckThePause()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (_isPausedGame)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }

        public void Pause()
        {
            _panelPause.SetActive(true);
            Time.timeScale = 0.0f;
            _isPausedGame = true;
        }

        public void Resume()
        {
            _panelPause.SetActive(false);
            Time.timeScale = 1.0f;
            _isPausedGame = false;
        }

        public void RestartTheGame()
        {
            SceneManager.LoadScene(Constants.NumberOfGameScene);
            Time.timeScale = 1.0f;
        }

        public void BackToMain()
        {
            SceneManager.LoadScene(Constants.NumberOfMainMenuScene);
            Time.timeScale = 1.0f;
        }

        public void ExitTheGame()
        {
            Application.Quit();
        }

        #endregion
    }
}
