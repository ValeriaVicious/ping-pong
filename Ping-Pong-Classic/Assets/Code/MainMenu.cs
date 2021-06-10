using UnityEngine;
using UnityEngine.SceneManagement;


namespace ThePingPong
{
    internal sealed class MainMenu : MonoBehaviour
    {
        #region Methods

        public void StartTheGame()
        {
            SceneManager.LoadScene(Constants.NumberOfGameScene);
        }

        public void Exit()
        {
            Application.Quit();
        }

        public void AboutAuthorScene()
        {
            SceneManager.LoadScene(Constants.NumberOfAboutAuthorScene);
        }

        public void BackToMainMenu()
        {
            SceneManager.LoadScene(Constants.NumberOfMainMenuScene);
        }

        #endregion
    }
}
