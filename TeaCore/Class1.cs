using BepInEx;
using UnityEngine;

namespace HelloMod
{
    [BepInPlugin("me.zhentai.plugin.HelloMod", "HelloWorld", "1.0.0")]
    public class HelloWorld : BaseUnityPlugin
    {
        void Awake() 
        {
            UnityEngine.Debug.Log("Unity: Hello World!");
            Logger.LogInfo("BepInEx: Hello World!");
        }
    }
}