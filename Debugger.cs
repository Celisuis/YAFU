using ColossalFramework;
using ColossalFramework.Plugins;
using ColossalFramework.UI;
using ICities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FeatureUnlocker
{
   public class Debugger
    {
        private static bool Initialized = false;

        private static bool isEnabled = false;

        public static bool XMLCorrupt = false;

        private static bool Loaded = false;

        private static string Exceptions = String.Empty;

        public static bool Enabled
        {
            get
            {
                return isEnabled;
            }
            set
            {
                if(value != isEnabled)
                {
                    if(isEnabled = value)
                    {
                        InitializeDebugger();
                    }
                }
                else
                {
                    DeinitializeDebugger();
                }
            }
        }

        public static void InitializeDebugger()
        {
            DeinitializeDebugger();

            if (Enabled)
                Initialized = true;
        }

        public static void DeinitializeDebugger()
        {
            if(Initialized)
            {
                Initialized = false;
                Exceptions = String.Empty;
                Loaded = false;

            }
        }

        public static void Log(string message)
        {
            if(Initialized && Enabled)
            {
                Debug.Log(message);
            }
        }

        public static void LogFormat(string format, params object[] args)
        {
            Log(String.Format(format, args));
        }

        public static void LogError(string error)
        {
            Debug.LogError(error);
        }

        public static void LogException(Exception e)
        {
            string message = "Error: " + e.Message + "\n" + e.StackTrace + "\n";

            Debug.LogException(e);

            Exceptions += message;

            if (Loaded)
            {
                ShowExceptions();
            }
        }

        public static void OnLevelLoaded()
        {
            Loaded = true;

            Debugger.AddModList();
            ShowExceptions();
        }

        public static void OnLevelUnloaded()
        {
            Loaded = false;

        }

        private static void ShowExceptions()
        {
            string text = null;

            if(XMLCorrupt)
            {
                text = "Feature Unlocker is unable to read your settings file.\n" +
                                "To fix this, please delete the following file and restart the game:\n" +
                                "{Steam folder}\\steamapps\\common\\Cities_Skylines\\FeatureUnlocker.xml";
            }
            else if(!String.IsNullOrEmpty(Exceptions))
            {
                text = "Please report this error" + Exceptions;
            }

            if(text != null)
            {
               

                Exceptions = String.Empty;
            }
        }

        public static void AddModList()
        {
            string message = "Enabled Mods:\n";

            foreach(var plugin in Singleton<PluginManager>.instance.GetPluginsInfo())
            {
                if(plugin.isEnabled)
                {
                    IUserMod mod = (IUserMod)plugin.userModInstance;

                    message += String.Format("# {0}\n", mod.Name);
                }
            }

            Debug.Log(message);
        }


    }
}
