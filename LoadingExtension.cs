using FeatureUnlocker.UnlockEngine;
using ICities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeatureUnlocker
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public override void OnCreated(ILoading loading)
        {
            base.OnCreated(loading);

            Debugger.InitializeDebugger();

            Debugger.Log("On_Level_Created");
            Debugger.Log("Feature Unlocker: Initializing");

            try
            {
                Unlocker.RegisterUnlocker();
                FeatureUnlockManager.instance.Reset();

                UpdateSettings();

                Debugger.Log("Feature Unlocker Successfully Initialized");
            }
            catch (Exception e)
            {
                Debugger.LogException(e);
            }


        }

        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);

            Debugger.Log("On_Level_Loaded");
            Debugger.OnLevelLoaded();

            try
            {
                if (mode != LoadMode.LoadGame && mode != LoadMode.NewGame)
                    return;

                Unlocker.UnlockButtons();
            }
            catch (Exception e)
            {
                Debugger.LogException(e);
            }
        }

        public override void OnLevelUnloading()
        {
            base.OnLevelUnloading();
            Debugger.Log("On_Level_Unloading");
            Debugger.OnLevelUnloaded();

            FeatureUnlockManager.instance.Reset();
        }

        public override void OnReleased()
        {
            base.OnReleased();

            Debugger.Log("On_Released");

            FeatureUnlockManager.instance.Reset();

            Debugger.DeinitializeDebugger();
        }

        private void UpdateSettings()
        {
            FeatureUnlockManager.instance.SaveSettings();
        }
    }
}
