using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace FeatureUnlocker.UnlockEngine
{
    public static class Unlocker
    {

        #region Unlock Settings

        public static bool UnlockerActive
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockerActive;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockerActive = value;
                FeatureUnlockManager.instance.SaveSettings();
            }
        }

        #region Features
        public static bool UnlockDistricts
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockDistricts;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockDistricts = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockPolicies
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockPolicies;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockPolicies = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockEconomy
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockEconomy;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockEconomy = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockBudget
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockBudgets;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockBudgets = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockTaxes
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockTaxes;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockTaxes = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockFirstLoan
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockFirstLoan;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockFirstLoan = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockSecondLoan
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockSecondLoan;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockSecondLoan = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockThirdLoan
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockThirdLoan;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockThirdLoan = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockIndustrySpecialization
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockIndustrySpecializations;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockIndustrySpecializations = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockCommercialSpecialization
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockCommercialSpecializations;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockCommercialSpecializations = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockResidentialSpecialization
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockResidentialSpecializations;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockResidentialSpecializations = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockOfficeSpecialization
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockOfficeSpecializations;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockOfficeSpecializations = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockParkAreas
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockParkAreas;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockParkAreas = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockLandscaping
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockLandscaping;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockLandscaping = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        #endregion

        #region Education

        public static bool UnlockEducation
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockEducation;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockEducation = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockSecondTierEducation
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockSecondTierEducation;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockSecondTierEducation = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockThirdTierEducation
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockThirdTierEducation;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockThirdTierEducation = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        #endregion

        #region Monuments

        public static bool UnlockMonuments
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockMonuments;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockMonuments = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockSecondTierMonuments
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockSecondTierMonuments;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockSecondTierMonuments = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockThirdTierMonuments
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockThirdTierMonuments;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockThirdTierMonuments = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockFourthTierMonuments
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockFourthTierMonuments;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockFourthTierMonuments = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockFifthTierMonuments
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockFifthTierMonuments;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockFifthTierMonuments = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockSixthTierMonuments
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockSixthTierMonuments;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockSixthTierMonuments = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        #endregion

        #region Buildings
        public static bool UnlockDeathCare
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockDeathCare;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockDeathCare = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockFootballStadiums
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockFootballStadiums;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockFootballStadiums = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockDisasterResponse
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockDisasterResponse;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockDisasterResponse = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockConcerts
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockConcerts;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockConcerts = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }


        public static bool UnlockWonders
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockWonders;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockWonders = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }



        #endregion

        #region Transport

        public static bool UnlockTransportService
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockTransportService;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockTransportService = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockBus
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockBus;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockBus = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockMetro
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockMetro;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockMetro = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockPlane
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockPlane;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockPlane = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockShips
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockShips;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockShips = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockTrains
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockTrains;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockTrains = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockTaxis
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockTaxis;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockTaxis = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockTrams
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockTrams;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockTrams = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockMonorail
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockMonorails;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockMonorails = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockCableCar
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockCableCar;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockCableCar = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }
        public static bool UnlockFerry
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockFerry;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockFerry = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockBlimp
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockBlimps;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockBlimps = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockSightseeingBus
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockSightseeingBus;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockSightseeingBus = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }

        public static bool UnlockWalkingTour
        {
            get
            {
                return FeatureUnlockManager.instance.Settings.UnlockWalkingTour;
            }
            set
            {
                FeatureUnlockManager.instance.Settings.UnlockWalkingTour = value;
                FeatureUnlockManager.instance.SaveSettings();

                if (UnlockerRegistered)
                    UnlockButtons();
            }
        }






        #endregion
        #endregion

        private static bool UnlockerRegistered = false;

        public static void RegisterUnlocker()
        {
            if (!UnlockerRegistered)
            {
                UnlockManager.instance.m_milestonesUpdated += new Action(TimedDistrictUnlock);
                UnlockerRegistered = true;
            }
        }

        public static void UnregisterUnlocker()
        {
            if (UnlockerRegistered)
            {
                UnlockManager.instance.m_milestonesUpdated -= new Action(TimedDistrictUnlock);
                UnlockerRegistered = false;
            }
        }

        public static void TimedDistrictUnlock()
        {
            if (UnlockerActive)
            {
                var timer = new Timer(300);

                timer.Elapsed += delegate (System.Object source, ElapsedEventArgs e)
                {
                    timer.Enabled = false;
                    timer.Dispose();
                    UnlockButtons();
                };
                timer.Enabled = true;
            }
        }


        #region Unlock Methods
        public static void UnlockButtons()
        {
            if (UnlockDistricts)
                UnlockDistrictButton();

            if (UnlockPolicies)
                UnlockPoliciesButton();

            if (UnlockEconomy)
                UnlockEconomyButton();

            if (UnlockBudget)
                UnlockBudgetsButton();

            if (UnlockTaxes)
                UnlockTaxesButton();

            if (UnlockFirstLoan)
                UnlockFirstLoanButton();

            if (UnlockSecondLoan)
                UnlockSecondLoanButton();

            if (UnlockThirdLoan)
                UnlockThirdLoanButton();

            if (UnlockCommercialSpecialization)
                UnlockCommercialSpecializationButton();

            if (UnlockIndustrySpecialization)
                UnlockIndustrySpecializationsButton();

            if (UnlockResidentialSpecialization)
                UnlockResidentialSpecializationsButton();

            if (UnlockOfficeSpecialization)
                UnlockOfficeSpecializationsButton();

            if (UnlockLandscaping)
                UnlockLandscapingButton();

            if (UnlockParkAreas)
                UnlockParkAreasButton();

            if (UnlockSecondTierEducation)
                UnlockSecondTierEducationButton();

            if (UnlockThirdTierEducation)
                UnlockThirdTierEducationButton();

            if (UnlockSecondTierMonuments)
                UnlockSecondTierMonumentsButton();

            if (UnlockThirdTierMonuments)
                UnlockThirdTierMonumentsButton();

            if (UnlockFourthTierMonuments)
                UnlockFourthTierMonumentsButton();

            if (UnlockFifthTierMonuments)
                UnlockFifthTierMonumentsButton();

            if (UnlockSixthTierMonuments)
                UnlockSixthTierMonumentsButton();

            if (UnlockDeathCare)
                UnlockDeathCareButton();

            if (UnlockDisasterResponse)
                UnlockDisasterResponseButton();

            if (UnlockFootballStadiums)
                UnlockFootballStadiumsButton();

            if (UnlockConcerts)
                UnlockConcertsButton();

            if (UnlockWonders)
                UnlockWondersButton();

            if (UnlockFerry)
                UnlockFerryButton();

            if (UnlockBlimp)
                UnlockBlimpsButton();

            if (UnlockSightseeingBus)
                UnlockSightseeingBusButton();

            if (UnlockWalkingTour)
                UnlockWalkingTourButton();

            if (UnlockTransportService)
                UnlockTransportServiceButton();

            if (UnlockBus)
                UnlockBusButton();

            if (UnlockMetro)
                UnlockMetroButton();

            if (UnlockPlane)
                UnlockPlaneButton();

            if (UnlockShips)
                UnlockShipsButton();

            if (UnlockTrains)
                UnlockTrainsButton();

            if (UnlockTaxis)
                UnlockTaxisButton();

            if (UnlockTrams)
                UnlockTramsButton();

            if (UnlockMonorail)
                UnlockMonorailsButton();

            if (UnlockCableCar)
                UnlockCableCarsButton();

            if (UnlockEducation)
                UnlockEducationButton();

            if (UnlockMonuments)
                UnlockMonumentsButton();
        }
        public static void UnlockDistrictButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Districts] = null;
        }

        public static void UnlockPoliciesButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Policies] = null;
        }

        public static void UnlockEconomyButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Economy] = null;
        }

        public static void UnlockBudgetsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Budget] = null;
        }

        public static void UnlockTaxesButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Taxes] = null;
        }

        public static void UnlockFirstLoanButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Loans] = null;
        }

        public static void UnlockSecondLoanButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.SecondLoan] = null;
        }

        public static void UnlockThirdLoanButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.ThirdLoan] = null;
        }

        public static void UnlockIndustrySpecializationsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.IndustrySpecializations] = null;
        }

        public static void UnlockCommercialSpecializationButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.CommercialSpecialization] = null;
        }

        public static void UnlockResidentialSpecializationsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.ResidentialSpecializations] = null;
        }

        public static void UnlockOfficeSpecializationsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.OfficeSpecializations] = null;
        }

        public static void UnlockLandscapingButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Landscaping] = null;
        }

        public static void UnlockParkAreasButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.ParkAreas] = null;
        }

        public static void UnlockEducationButton()
        {
            UnlockManager.instance.m_properties.m_ServiceMilestones[(int)ItemClass.Service.Education] = null;
        }

        public static void UnlockSecondTierEducationButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.EducationLevel2] = null;
        }

        public static void UnlockThirdTierEducationButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.EducationLevel3] = null;
        }

        public static void UnlockMonumentsButton()
        {
            UnlockManager.instance.m_properties.m_ServiceMilestones[(int)ItemClass.Service.Monument] = null;
        }
        public static void UnlockSecondTierMonumentsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.MonumentLevel2] = null;
        }

        public static void UnlockThirdTierMonumentsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.MonumentLevel3] = null;
        }

        public static void UnlockFourthTierMonumentsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.MonumentLevel4] = null;
        }

        public static void UnlockFifthTierMonumentsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.MonumentLevel5] = null;
        }

        public static void UnlockSixthTierMonumentsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.MonumentLevel6] = null;
            
        }

        public static void UnlockDeathCareButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.DeathCare] = null;
        }

        public static void UnlockFootballStadiumsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Football] = null;
        }

        public static void UnlockConcertsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Concerts] = null;
        }

        public static void UnlockDisasterResponseButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.DisasterResponse] = null;
        }

        public static void UnlockWondersButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Wonders] = null;
        }

        public static void UnlockFerryButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Ferry] = null;
        }

        public static void UnlockBlimpsButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.Blimp] = null;
        }

        public static void UnlockSightseeingBusButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.SightseeingBus] = null;
        }

        public static void UnlockWalkingTourButton()
        {
            UnlockManager.instance.m_properties.m_FeatureMilestones[(int)UnlockManager.Feature.WalkingTour] = null;
        }

        public static void UnlockTransportServiceButton()
        {
            UnlockManager.instance.m_properties.m_ServiceMilestones[(int)ItemClass.Service.PublicTransport] = null;
        }

        public static void UnlockBusButton()
        {
            UnlockManager.instance.m_properties.m_SubServiceMilestones[(int)ItemClass.SubService.PublicTransportBus] = null;

            for (uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
            {
                BuildingInfo buildInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                if (buildInfo != null)
                {
                    if (buildInfo.m_class.m_subService == ItemClass.SubService.PublicTransportBus)
                        buildInfo.m_UnlockMilestone = null;

                    

                }
            }

            for(uint x = 0; x < PrefabCollection<TransportInfo>.LoadedCount(); x++)
            {
                TransportInfo transportInfo = PrefabCollection<TransportInfo>.GetLoaded(x);

                if(transportInfo != null)
                {
                    if (transportInfo.m_class.m_subService == ItemClass.SubService.PublicTransportBus)
                        transportInfo.m_UnlockMilestone = null;
                }
            }

            NetInfo busLane = PrefabCollection<NetInfo>.FindLoaded("Avenue Large With Buslanes Grass");
            if (busLane != null)
                busLane.m_UnlockMilestone = null;

            for(uint z = 0; z < PrefabCollection<NetInfo>.LoadedCount(); z++)
            {
                NetInfo netInfo = PrefabCollection<NetInfo>.GetLoaded(z);

                if(netInfo != null)
                {
                    if (netInfo.m_class.m_subService == ItemClass.SubService.PublicTransportBus)
                        netInfo.m_UnlockMilestone = null;
                }
            }
        }

        public static void UnlockMetroButton()
        {
            UnlockManager.instance.m_properties.m_SubServiceMilestones[(int)ItemClass.SubService.PublicTransportMetro] = null;

            for(uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
            {
                BuildingInfo buildInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                if(buildInfo != null)
                {
                    if (buildInfo.m_class.m_subService == ItemClass.SubService.PublicTransportMetro)
                        buildInfo.m_UnlockMilestone = null;
                }
            }

            for (uint x = 0; x < PrefabCollection<TransportInfo>.LoadedCount(); x++)
            {
                TransportInfo transportInfo = PrefabCollection<TransportInfo>.GetLoaded(x);

                if (transportInfo != null)
                {
                    if (transportInfo.m_class.m_subService == ItemClass.SubService.PublicTransportMetro)
                        transportInfo.m_UnlockMilestone = null;
                }
            }

            for (uint z = 0; z < PrefabCollection<NetInfo>.LoadedCount(); z++)
            {
                NetInfo netInfo = PrefabCollection<NetInfo>.GetLoaded(z);

                if (netInfo != null)
                {
                    if (netInfo.m_class.m_subService == ItemClass.SubService.PublicTransportMetro)
                        netInfo.m_UnlockMilestone = null;
                }
            }
        }

        public static void UnlockPlaneButton()
        {
            UnlockManager.instance.m_properties.m_SubServiceMilestones[(int)ItemClass.SubService.PublicTransportPlane] = null;

            for (uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
            {
                BuildingInfo buildInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                if (buildInfo != null)
                {
                    if (buildInfo.m_class.m_subService == ItemClass.SubService.PublicTransportPlane)
                        buildInfo.m_UnlockMilestone = null;
                }
            }

            for (uint x = 0; x < PrefabCollection<TransportInfo>.LoadedCount(); x++)
            {
                TransportInfo transportInfo = PrefabCollection<TransportInfo>.GetLoaded(x);

                if (transportInfo != null)
                {
                    if (transportInfo.m_class.m_subService == ItemClass.SubService.PublicTransportPlane)
                        transportInfo.m_UnlockMilestone = null;
                }
            }

            for (uint z = 0; z < PrefabCollection<NetInfo>.LoadedCount(); z++)
            {
                NetInfo netInfo = PrefabCollection<NetInfo>.GetLoaded(z);

                if (netInfo != null)
                {
                    if (netInfo.m_class.m_subService == ItemClass.SubService.PublicTransportPlane)
                        netInfo.m_UnlockMilestone = null;
                }
            }
        }

        public static void UnlockShipsButton()
        {
            UnlockManager.instance.m_properties.m_SubServiceMilestones[(int)ItemClass.SubService.PublicTransportShip] = null;

            for (uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
            {
                BuildingInfo buildInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                if (buildInfo != null)
                {
                    if (buildInfo.m_class.m_subService == ItemClass.SubService.PublicTransportShip)
                        buildInfo.m_UnlockMilestone = null;
                }
            }

            for (uint x = 0; x < PrefabCollection<TransportInfo>.LoadedCount(); x++)
            {
                TransportInfo transportInfo = PrefabCollection<TransportInfo>.GetLoaded(x);

                if (transportInfo != null)
                {
                    if (transportInfo.m_class.m_subService == ItemClass.SubService.PublicTransportShip)
                        transportInfo.m_UnlockMilestone = null;
                }
            }

            for (uint z = 0; z < PrefabCollection<NetInfo>.LoadedCount(); z++)
            {
                NetInfo netInfo = PrefabCollection<NetInfo>.GetLoaded(z);

                if (netInfo != null)
                {
                    if (netInfo.m_class.m_subService == ItemClass.SubService.PublicTransportShip)
                        netInfo.m_UnlockMilestone = null;
                }
            }

        }

        public static void UnlockTrainsButton()
        {
            UnlockManager.instance.m_properties.m_SubServiceMilestones[(int)ItemClass.SubService.PublicTransportTrain] = null;

            for (uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
            {
                BuildingInfo buildInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                if (buildInfo != null)
                {
                    if (buildInfo.m_class.m_subService == ItemClass.SubService.PublicTransportTrain)
                        buildInfo.m_UnlockMilestone = null;
                }
            }

            for (uint x = 0; x < PrefabCollection<TransportInfo>.LoadedCount(); x++)
            {
                TransportInfo transportInfo = PrefabCollection<TransportInfo>.GetLoaded(x);

                if (transportInfo != null)
                {
                    if (transportInfo.m_class.m_subService == ItemClass.SubService.PublicTransportTrain)
                        transportInfo.m_UnlockMilestone = null;
                }
            }

            for (uint z = 0; z < PrefabCollection<NetInfo>.LoadedCount(); z++)
            {
                NetInfo netInfo = PrefabCollection<NetInfo>.GetLoaded(z);

                if (netInfo != null)
                {
                    if (netInfo.m_class.m_subService == ItemClass.SubService.PublicTransportTrain)
                        netInfo.m_UnlockMilestone = null;
                }
            }
        }

        public static void UnlockTaxisButton()
        {
            UnlockManager.instance.m_properties.m_SubServiceMilestones[(int)ItemClass.SubService.PublicTransportTaxi] = null;

            for (uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
            {
                BuildingInfo buildInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                if (buildInfo != null)
                {
                    if (buildInfo.m_class.m_subService == ItemClass.SubService.PublicTransportTaxi)
                        buildInfo.m_UnlockMilestone = null;
                }
            }

            for (uint x = 0; x < PrefabCollection<TransportInfo>.LoadedCount(); x++)
            {
                TransportInfo transportInfo = PrefabCollection<TransportInfo>.GetLoaded(x);

                if (transportInfo != null)
                {
                    if (transportInfo.m_class.m_subService == ItemClass.SubService.PublicTransportTaxi)
                        transportInfo.m_UnlockMilestone = null;
                }
            }

            for (uint z = 0; z < PrefabCollection<NetInfo>.LoadedCount(); z++)
            {
                NetInfo netInfo = PrefabCollection<NetInfo>.GetLoaded(z);

                if (netInfo != null)
                {
                    if (netInfo.m_class.m_subService == ItemClass.SubService.PublicTransportTaxi)
                        netInfo.m_UnlockMilestone = null;
                }
            }
        }

        public static void UnlockTramsButton()
        {
            UnlockManager.instance.m_properties.m_SubServiceMilestones[(int)ItemClass.SubService.PublicTransportTram] = null;

            for (uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
            {
                BuildingInfo buildInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                if (buildInfo != null)
                {
                    if (buildInfo.m_class.m_subService == ItemClass.SubService.PublicTransportTram)
                        buildInfo.m_UnlockMilestone = null;
                }
            }

            for (uint x = 0; x < PrefabCollection<TransportInfo>.LoadedCount(); x++)
            {
                TransportInfo transportInfo = PrefabCollection<TransportInfo>.GetLoaded(x);

                if (transportInfo != null)
                {
                    if (transportInfo.m_class.m_subService == ItemClass.SubService.PublicTransportTram)
                        transportInfo.m_UnlockMilestone = null;
                }
            }

            for (uint z = 0; z < PrefabCollection<NetInfo>.LoadedCount(); z++)
            {
                NetInfo netInfo = PrefabCollection<NetInfo>.GetLoaded(z);

                if (netInfo != null)
                {
                    if (netInfo.m_class.m_subService == ItemClass.SubService.PublicTransportTram)
                        netInfo.m_UnlockMilestone = null;
                }
            }
        }

        public static void UnlockMonorailsButton()
        {
            UnlockManager.instance.m_properties.m_SubServiceMilestones[(int)ItemClass.SubService.PublicTransportMonorail] = null;

            for (uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
            {
                BuildingInfo buildInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                if (buildInfo != null)
                {
                    if (buildInfo.m_class.m_subService == ItemClass.SubService.PublicTransportMonorail)
                        buildInfo.m_UnlockMilestone = null;
                }
            }

            for (uint x = 0; x < PrefabCollection<TransportInfo>.LoadedCount(); x++)
            {
                TransportInfo transportInfo = PrefabCollection<TransportInfo>.GetLoaded(x);

                if (transportInfo != null)
                {
                    if (transportInfo.m_class.m_subService == ItemClass.SubService.PublicTransportMonorail)
                        transportInfo.m_UnlockMilestone = null;
                }
            }

            for (uint z = 0; z < PrefabCollection<NetInfo>.LoadedCount(); z++)
            {
                NetInfo netInfo = PrefabCollection<NetInfo>.GetLoaded(z);

                if (netInfo != null)
                {
                    if ((netInfo.m_class.m_subService == ItemClass.SubService.PublicTransportMonorail) || IsMonorailConnect(netInfo))
                        netInfo.m_UnlockMilestone = null;
                }
            }
        }

        private static bool IsMonorailConnect(NetInfo netInfo)
        {
            if (netInfo.m_connectGroup == NetInfo.ConnectGroup.SingleMonorail || netInfo.m_connectGroup == NetInfo.ConnectGroup.DoubleMonorail || netInfo.m_connectGroup == NetInfo.ConnectGroup.MonorailStation)
                return true;
            else
                return false;
        }
        public static void UnlockCableCarsButton()
        {
            UnlockManager.instance.m_properties.m_SubServiceMilestones[(int)ItemClass.SubService.PublicTransportCableCar] = null;

            for (uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
            {
                BuildingInfo buildInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                if (buildInfo != null)
                {
                    if (buildInfo.m_class.m_subService == ItemClass.SubService.PublicTransportCableCar)
                        buildInfo.m_UnlockMilestone = null;
                }
            }

            for (uint x = 0; x < PrefabCollection<TransportInfo>.LoadedCount(); x++)
            {
                TransportInfo transportInfo = PrefabCollection<TransportInfo>.GetLoaded(x);

                if (transportInfo != null)
                {
                    if (transportInfo.m_class.m_subService == ItemClass.SubService.PublicTransportCableCar)
                        transportInfo.m_UnlockMilestone = null;
                }
            }
        }




        #endregion
    }
    }
