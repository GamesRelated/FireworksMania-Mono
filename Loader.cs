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

namespace FMMono
{
    public class Loader : MonoBehaviour
    {
        public static void Init()
        {
            Loader.Load = new GameObject();
            Loader.Load.AddComponent<Main>();
            UnityEngine.Object.DontDestroyOnLoad(Loader.Load);
        }
        public static void Unload()
        {
            _Unload();
        }
        private static void _Unload()
        {
            GameObject.Destroy(Loader.Load);
        }
        private static GameObject Load;
    }
}
