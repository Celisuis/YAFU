using ColossalFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeatureUnlocker.UnlockEngine
{
   public class FeatureUnlockManager : Singleton<FeatureUnlockManager>
    {
        private const string FilePath = "FeatureUnlocker.xml";

        private const string userFilePath = "FeatureUnlocker.xml";

        private Settings _Settings;

        internal Settings Settings
        {
            get
            {
                if(_Settings == null)
                {
                    try
                    {
                        _Settings = Settings.Deserialize(userFilePath);

                        if (Debugger.Enabled)
                            Debugger.Log("Feature Unlocker Settings Successfully Loaded.");

                        if(_Settings == null)
                        {
                            _Settings = new Settings();
                            SaveSettings();
                        }

                        Debugger.XMLCorrupt = false;
                    }
                    catch (Exception e)
                    {
                        Debugger.XMLCorrupt = true;
                        Debugger.LogException(e);
                    }
                }

                return _Settings;
            }
        }

        internal void SaveSettings()
        {
            if(_Settings != null)
            {
                Settings.Serialize(userFilePath, _Settings);
            }
        }

        public void Reset()
        {
            _Settings = null;
        }


    }
}
