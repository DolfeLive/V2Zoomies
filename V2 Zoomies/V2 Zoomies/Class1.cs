using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static UnityEngine.Scripting.GarbageCollector;
using UnityEngine.AddressableAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using HarmonyLib;
using System.Collections;
using UnityEngine.SceneManagement;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace V2_Zoomies
{
    [BepInPlugin("DolfeLive.Ultrakill.UltraMines", "V2Zoomies", "1.0.0")]
    public class V2Zoomies : BaseUnityPlugin
    {
        public const string pluginGuid = "DolfeLive.Ultrakill.V2Zoomies";
        public const string pluginName = "V2Zoomies";
        public const string pluginVersion = "1.0.0.0";

        private GameObject V2;
        private Rigidbody V2RB;
        private float zoomies = 500;
        private bool ZoomiesBegin = false;

        void Update()
        {
            V2 = GameObject.Find("V2");
            V2RB = V2.GetComponent<Rigidbody>();
            bool StartZoomies = Input.GetKeyDown(KeyCode.Z);

            if (StartZoomies)
            {
                ZoomiesBegin = !ZoomiesBegin;
                Logger.LogInfo("Zoomies swaped");
            }

            if (ZoomiesBegin)
            {
                V2RB.velocity = V2.transform.forward * zoomies;
                Logger.LogInfo("Running Zoomies");
            }
            
        
        }
    }
}
