using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Doozy.Engine;
using Doozy.Engine.UI;
using FireworksGame;
using FireworksGame.Input;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

namespace FMMono
{
    class GameManager : MonoBehaviour
    {
        public Player _player;
        public Vector3 _initialSpawnPosition;
        public void Start()
        {
            this._initialSpawnPosition = base.transform.position;
        }
        // Player Object
        public void PlayerObject()
        {
            _player = FindObjectOfType<Player>();
        }
        public void PlayerRespawn()
        {
            base.transform.position = this._initialSpawnPosition;
            FirstPersonController component = base.GetComponent<FirstPersonController>();
            if (component != null)
            {
                component.ResetMovement();
            }
        }
        // Game Scenes
        public string CurrentSceneName()
        {
            return SceneManager.GetActiveScene().name;
        }
        public void RestartCurrentMap()
        {
            SceneLoadingManager.Instance.LoadSceneWithLoadingScreen(CurrentSceneName());
        }
        public void LoadTheTownDay()
        {
            SceneLoadingManager.Instance.LoadSceneWithLoadingScreen("TheTown-Day");
        }
        public void LoadTheTownNight()
        {
            SceneLoadingManager.Instance.LoadSceneWithLoadingScreen("TheTown-Night");
        }
        public void LoadTheRanchNight()
        {
            SceneLoadingManager.Instance.LoadSceneWithLoadingScreen("TheRanch-Night");
        }
        public void LoadTheLab()
        {
            SceneLoadingManager.Instance.LoadSceneWithLoadingScreen("TheLab");
        }
        public void LoadMainMenu()
        {
            SceneLoadingManager.Instance.LoadSceneWithLoadingScreen("MainMenu");
        }
        public void LoadInitialer()
        {
            SceneLoadingManager.Instance.LoadSceneWithOutLoadingScreen("Initializer");
        }

        // Firwork Objects
        public void FireWorkManager()
        {

        }
    }
}
