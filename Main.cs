using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using Doozy.Engine;
using Doozy.Engine.UI;
using FireworksGame;
using FireworksGame.Input;

namespace FMMono
{
    class Main : MonoBehaviour
    { 
        public void Start()
        {
            
        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (GetComponent<GameManager>()._player != null)
                {
                    GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 150f, 50f), "Menu injected");
                }
            }
        }
    }
}
