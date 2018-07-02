using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FeatureUnlocker
{
    public class Settings
    {

        #region Settings

        #region Features

        public bool UnlockerActive = true;

        public bool UnlockDistricts = true;
        public bool UnlockPolicies = false;
        public bool UnlockEconomy = false;
        public bool UnlockBudgets = false;
        public bool UnlockTaxes = false;
        public bool UnlockFirstLoan = false;
        public bool UnlockSecondLoan = false;
        public bool UnlockThirdLoan = false;
        public bool UnlockIndustrySpecializations = false;
        public bool UnlockCommercialSpecializations = false;
        public bool UnlockResidentialSpecializations = false;
        public bool UnlockOfficeSpecializations = false;
        public bool UnlockLandscaping = false;
        public bool UnlockParkAreas = false;

        #endregion

        #region Education
        public bool UnlockEducation = false;
        public bool UnlockSecondTierEducation = false;
        public bool UnlockThirdTierEducation = false;
        #endregion

        #region Monuments
        public bool UnlockMonuments = false;
        public bool UnlockSecondTierMonuments = false;
        public bool UnlockThirdTierMonuments = false;
        public bool UnlockFourthTierMonuments = false;
        public bool UnlockFifthTierMonuments = false;
        public bool UnlockSixthTierMonuments = false;
        #endregion

        #region Buildings
        public bool UnlockDeathCare = false;
        public bool UnlockFootballStadiums = false;
        public bool UnlockConcerts = false;
        public bool UnlockDisasterResponse = false;
        public bool UnlockWonders = false;
        #endregion

        #region Transport
        public bool UnlockTransportService = false;
        public bool UnlockBus = false;
        public bool UnlockMetro = false;
        public bool UnlockPlane = false;
        public bool UnlockShips = false;
        public bool UnlockTrains = false;
        public bool UnlockTaxis = false;
        public bool UnlockTrams = false;
        public bool UnlockMonorails = false;
        public bool UnlockCableCar = false;
        public bool UnlockFerry = false;
        public bool UnlockBlimps = false;
        public bool UnlockSightseeingBus = false;
        public bool UnlockWalkingTour = false;

        #endregion

        #endregion

        public static Settings Deserialize(string fileName)
        {
            if (!File.Exists(fileName))
                return null;

            XmlSerializer xmlSerial = new XmlSerializer(typeof(Settings));
            try
            {
                using (System.IO.StreamReader reader = new StreamReader(fileName))
                {
                    return (Settings)xmlSerial.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Debugger.Log("XML Settings couldn't be loaded.");
                throw e;
            }
        }

        public static void Serialize(string fileName, Settings settings)
        {
            var xmlSerial = new XmlSerializer(typeof(Settings));
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    var settingsCopy = new Settings();
                    
                    settingsCopy.UnlockDistricts = settings.UnlockDistricts;
                    settingsCopy.UnlockBlimps = settings.UnlockBlimps;
                    settingsCopy.UnlockBudgets = settings.UnlockBudgets;
                    settingsCopy.UnlockBus = settings.UnlockBus;
                    settingsCopy.UnlockCableCar = settings.UnlockCableCar;
                    settingsCopy.UnlockCommercialSpecializations = settings.UnlockCommercialSpecializations;
                    settingsCopy.UnlockConcerts = settings.UnlockConcerts;
                    settingsCopy.UnlockDeathCare = settings.UnlockDeathCare;
                    settingsCopy.UnlockDisasterResponse = settings.UnlockDisasterResponse;
                    settingsCopy.UnlockEconomy = settings.UnlockEconomy;
                    settingsCopy.UnlockerActive = settings.UnlockerActive;
                    settingsCopy.UnlockFerry = settings.UnlockFerry;
                    settingsCopy.UnlockFifthTierMonuments = settings.UnlockFifthTierMonuments;
                    settingsCopy.UnlockFirstLoan = settings.UnlockFirstLoan;
                    settingsCopy.UnlockFootballStadiums = settings.UnlockFootballStadiums;
                    settingsCopy.UnlockFourthTierMonuments = settings.UnlockFourthTierMonuments;
                    settingsCopy.UnlockIndustrySpecializations = settings.UnlockIndustrySpecializations;
                    settingsCopy.UnlockLandscaping = settings.UnlockLandscaping;
                    settingsCopy.UnlockMetro = settings.UnlockMetro;
                    settingsCopy.UnlockMonorails = settings.UnlockMonorails;
                    settingsCopy.UnlockOfficeSpecializations = settings.UnlockOfficeSpecializations;
                    settingsCopy.UnlockParkAreas = settings.UnlockParkAreas;
                    settingsCopy.UnlockPlane = settings.UnlockPlane;
                    settingsCopy.UnlockPolicies = settings.UnlockPolicies;
                    settingsCopy.UnlockResidentialSpecializations = settings.UnlockResidentialSpecializations;
                    settingsCopy.UnlockSecondLoan = settings.UnlockSecondLoan;
                    settingsCopy.UnlockSecondTierEducation = settings.UnlockSecondTierEducation;
                    settingsCopy.UnlockSecondTierMonuments = settings.UnlockSecondTierMonuments;
                    settingsCopy.UnlockShips = settings.UnlockShips;
                    settingsCopy.UnlockSightseeingBus = settings.UnlockSightseeingBus;
                    settingsCopy.UnlockSixthTierMonuments = settings.UnlockSixthTierMonuments;
                    settingsCopy.UnlockTaxes = settings.UnlockTaxes;
                    settingsCopy.UnlockTaxis = settings.UnlockTaxis;
                    settingsCopy.UnlockThirdLoan = settings.UnlockThirdLoan;
                    settingsCopy.UnlockThirdTierEducation = settings.UnlockThirdTierEducation;
                    settingsCopy.UnlockThirdTierMonuments = settings.UnlockThirdTierMonuments;
                    settingsCopy.UnlockTrains = settings.UnlockTrains;
                    settingsCopy.UnlockTrams = settings.UnlockTrams;
                    settingsCopy.UnlockTransportService = settings.UnlockTransportService;
                    settingsCopy.UnlockWalkingTour = settings.UnlockWalkingTour;
                    settingsCopy.UnlockWonders = settings.UnlockWonders;
                    settingsCopy.UnlockEducation = settings.UnlockEducation;
                    settingsCopy.UnlockMonuments = settings.UnlockMonuments;

                    xmlSerial.Serialize(writer, settingsCopy);

                }
            }
            catch (Exception e)
            {
                Debugger.Log("Couldn't create XML Settings File.");
                throw e;
            }
        }

    }
}
