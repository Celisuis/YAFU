using ColossalFramework.UI;
using FeatureUnlocker.UnlockEngine;
using ICities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FeatureUnlocker
{
    public class FeatureUnlockerMod : IUserMod
    {

        public int MinorVersion = 5;
        public int MajorVersion = 0;
        public int IncrementalVersion = 0;

        public string Name
        {
            get
            {
                return "YAFU - Yet Another Feature Unlocker";
            }
        }

        public string Description
        {
            get
            {
                return $"Unlocks Selected Features. Version: {MajorVersion}.{MinorVersion}.{IncrementalVersion}";
            }
        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            UIHelper actualHelp = helper as UIHelper;
            UIComponent container = actualHelp.self as UIComponent;

            UITabstrip tabStrip = container.AddUIComponent<UITabstrip>();
            tabStrip.relativePosition = new Vector3(0, 0);
            tabStrip.size = new Vector2(container.width - 20, 40);

            UITabContainer tabContainer = container.AddUIComponent<UITabContainer>();
            tabContainer.relativePosition = new Vector3(0, 40);
            tabContainer.size = new Vector2(container.width - 20, container.height - tabStrip.height - 20); ;

            tabStrip.tabPages = tabContainer;

            int tabIndex = 0;

            #region Features
            AddTab(tabStrip, "Features");
            tabStrip.selectedIndex = tabIndex;

            UIPanel currentPanel = tabStrip.tabContainer.components[tabIndex] as UIPanel;
            currentPanel.autoLayout = true;
            currentPanel.autoLayoutDirection = LayoutDirection.Vertical;
            currentPanel.autoLayoutPadding.top = 5;
            currentPanel.autoLayoutPadding.left = 10;
            currentPanel.autoLayoutPadding.right = 10;

            UIHelper panelHelper = new UIHelper(currentPanel);

            var FeatureGroup = panelHelper.AddGroup("Features");
            FeatureGroup.AddCheckbox("Unlocker Enabled", Unlocker.UnlockerActive, delegate (bool x) { Unlocker.UnlockerActive = x; });
            FeatureGroup.AddCheckbox("Unlock Districts", Unlocker.UnlockDistricts, delegate (bool x) { Unlocker.UnlockDistricts = x; });
            FeatureGroup.AddCheckbox("Unlock Policies", Unlocker.UnlockPolicies, delegate (bool x) { Unlocker.UnlockPolicies = x; });
            FeatureGroup.AddCheckbox("Unlock Budget", Unlocker.UnlockBudget, delegate (bool x) { Unlocker.UnlockBudget = x; });
            FeatureGroup.AddCheckbox("Unlock Taxes", Unlocker.UnlockTaxes, delegate (bool x) { Unlocker.UnlockTaxes = x; });
            FeatureGroup.AddCheckbox("Unlock First Loan", Unlocker.UnlockFirstLoan, delegate (bool x) { Unlocker.UnlockFirstLoan = x; });
            FeatureGroup.AddCheckbox("Unlock Second Loan", Unlocker.UnlockSecondLoan, delegate (bool x) { Unlocker.UnlockSecondLoan = x; });
            FeatureGroup.AddCheckbox("Unlock Third Loan", Unlocker.UnlockThirdLoan, delegate (bool x) { Unlocker.UnlockThirdLoan = x; });
            FeatureGroup.AddCheckbox("Unlock Industrial Specializations", Unlocker.UnlockIndustrySpecialization, delegate (bool x) { Unlocker.UnlockIndustrySpecialization = x; });
            FeatureGroup.AddCheckbox("Unlock Commercial Specializations", Unlocker.UnlockCommercialSpecialization, delegate (bool x) { Unlocker.UnlockCommercialSpecialization = x; });
            FeatureGroup.AddCheckbox("Unlock Residential Specializations", Unlocker.UnlockResidentialSpecialization, delegate (bool x) { Unlocker.UnlockResidentialSpecialization = x; });
            FeatureGroup.AddCheckbox("Unlock Office Specializations", Unlocker.UnlockOfficeSpecialization, delegate (bool x) { Unlocker.UnlockOfficeSpecialization = x; });
            FeatureGroup.AddCheckbox("Unlock Landscaping", Unlocker.UnlockLandscaping, delegate (bool x) { Unlocker.UnlockLandscaping = x; });
            FeatureGroup.AddCheckbox("Unlock Park Areas", Unlocker.UnlockParkAreas, delegate (bool x) { Unlocker.UnlockParkAreas = x; });
            #endregion

            #region Education
            ++tabIndex;

            AddTab(tabStrip, "Education");
            tabStrip.selectedIndex = tabIndex;

            currentPanel = tabStrip.tabContainer.components[tabIndex] as UIPanel;
            currentPanel.autoLayout = true;
            currentPanel.autoLayoutDirection = LayoutDirection.Vertical;
            currentPanel.autoLayoutPadding.top = 5;
            currentPanel.autoLayoutPadding.left = 10;
            currentPanel.autoLayoutPadding.right = 10;

            panelHelper = new UIHelper(currentPanel);

            var EducationGroup = panelHelper.AddGroup("Education");
            EducationGroup.AddCheckbox("Unlock Education", Unlocker.UnlockEducation, delegate (bool x) { Unlocker.UnlockEducation = x; });
            EducationGroup.AddCheckbox("Unlock Second Tier Education", Unlocker.UnlockSecondTierEducation, delegate (bool x) { Unlocker.UnlockSecondTierEducation = x; });
            EducationGroup.AddCheckbox("Unlock Third Tier Education", Unlocker.UnlockThirdTierEducation, delegate (bool x) { Unlocker.UnlockThirdTierEducation = x; });
            #endregion

            #region Monuments
            ++tabIndex;

            AddTab(tabStrip, "Monuments");
            tabStrip.selectedIndex = tabIndex;

            currentPanel = tabStrip.tabContainer.components[tabIndex] as UIPanel;
            currentPanel.autoLayout = true;
            currentPanel.autoLayoutDirection = LayoutDirection.Vertical;
            currentPanel.autoLayoutPadding.top = 5;
            currentPanel.autoLayoutPadding.left = 10;
            currentPanel.autoLayoutPadding.right = 10;

            panelHelper = new UIHelper(currentPanel);

            var MonumentsGroup = panelHelper.AddGroup("Monuments");
            MonumentsGroup.AddCheckbox("Unlock Monuments", Unlocker.UnlockMonuments, delegate (bool x) { Unlocker.UnlockMonuments = x; });
            MonumentsGroup.AddCheckbox("Unlock Second Tier Monuments", Unlocker.UnlockSecondTierMonuments, delegate (bool x) { Unlocker.UnlockSecondTierMonuments = x; });
            MonumentsGroup.AddCheckbox("Unlock Third Tier Monuments", Unlocker.UnlockThirdTierMonuments, delegate (bool x) { Unlocker.UnlockThirdTierMonuments = x; });
            MonumentsGroup.AddCheckbox("Unlock Fourth Tier Monuments", Unlocker.UnlockFourthTierMonuments, delegate (bool x) { Unlocker.UnlockFourthTierMonuments = x; });
            MonumentsGroup.AddCheckbox("Unlock Fifth Tier Monuments", Unlocker.UnlockFifthTierMonuments, delegate (bool x) { Unlocker.UnlockFifthTierMonuments = x; });
            MonumentsGroup.AddCheckbox("Unlock Sixth Tier Monuments", Unlocker.UnlockSixthTierMonuments, delegate (bool x) { Unlocker.UnlockSixthTierMonuments = x; });

            #endregion

            #region Buildings
            ++tabIndex;

            AddTab(tabStrip, "Buildings");
            tabStrip.selectedIndex = tabIndex;

            currentPanel = tabStrip.tabContainer.components[tabIndex] as UIPanel;
            currentPanel.autoLayout = true;
            currentPanel.autoLayoutDirection = LayoutDirection.Vertical;
            currentPanel.autoLayoutPadding.top = 5;
            currentPanel.autoLayoutPadding.left = 10;
            currentPanel.autoLayoutPadding.right = 10;

            panelHelper = new UIHelper(currentPanel);

            var BuildingsGroup = panelHelper.AddGroup("Buildings");
            BuildingsGroup.AddCheckbox("Unlock Death Care Buildings", Unlocker.UnlockDeathCare, delegate (bool x) { Unlocker.UnlockDeathCare = x; });
            BuildingsGroup.AddCheckbox("Unlock Football Stadiums", Unlocker.UnlockFootballStadiums, delegate (bool x) { Unlocker.UnlockFootballStadiums = x; });
            BuildingsGroup.AddCheckbox("Unlock Concerts", Unlocker.UnlockConcerts, delegate (bool x) { Unlocker.UnlockConcerts = x; });
            BuildingsGroup.AddCheckbox("Unlock Disaster Response Buildings", Unlocker.UnlockDisasterResponse, delegate (bool x) { Unlocker.UnlockDisasterResponse = x; });
            BuildingsGroup.AddCheckbox("Unlock Wonder Buildings", Unlocker.UnlockWonders, delegate (bool x) { Unlocker.UnlockWonders = x; });
            #endregion

            #region Transport
            ++tabIndex;

            AddTab(tabStrip, "Transport");
            tabStrip.selectedIndex = tabIndex;

            currentPanel = tabStrip.tabContainer.components[tabIndex] as UIPanel;
            currentPanel.autoLayout = true;
            currentPanel.autoLayoutDirection = LayoutDirection.Vertical;
            currentPanel.autoLayoutPadding.top = 5;
            currentPanel.autoLayoutPadding.left = 10;
            currentPanel.autoLayoutPadding.right = 10;

            panelHelper = new UIHelper(currentPanel);

            var TransportGroup = panelHelper.AddGroup("Transport");
            TransportGroup.AddCheckbox("Unlock Transport Service (Must be Enabled for setting below)", Unlocker.UnlockTransportService, delegate (bool x) { Unlocker.UnlockTransportService = x; });
            TransportGroup.AddCheckbox("Unlock Buses and Stations", Unlocker.UnlockBus, delegate (bool x) { Unlocker.UnlockBus = x; });
            TransportGroup.AddCheckbox("Unlock Metro and Stations", Unlocker.UnlockMetro, delegate (bool x) { Unlocker.UnlockMetro = x; });
            TransportGroup.AddCheckbox("Unlock Airports and Planes", Unlocker.UnlockPlane, delegate (bool x) { Unlocker.UnlockPlane = x; });
            TransportGroup.AddCheckbox("Unlock Ships", Unlocker.UnlockShips, delegate (bool x) { Unlocker.UnlockShips = x; });
            TransportGroup.AddCheckbox("Unlock Trains and Stations", Unlocker.UnlockTrains, delegate (bool x) { Unlocker.UnlockTrains = x; });
            TransportGroup.AddCheckbox("Unlock Taxis", Unlocker.UnlockTaxis, delegate (bool x) { Unlocker.UnlockTaxis = x; });
            TransportGroup.AddCheckbox("Unlock Trams and Stations", Unlocker.UnlockTrams, delegate (bool x) { Unlocker.UnlockTrams = x; });
            TransportGroup.AddCheckbox("Unlock Monorail and Stations", Unlocker.UnlockMonorail, delegate (bool x) { Unlocker.UnlockMonorail = x; });
            TransportGroup.AddCheckbox("Unlock Cable Cars", Unlocker.UnlockCableCar, delegate (bool x) { Unlocker.UnlockCableCar = x; });
            TransportGroup.AddCheckbox("Unlock Ferries", Unlocker.UnlockFerry, delegate (bool x) { Unlocker.UnlockFerry = x; });
            TransportGroup.AddCheckbox("Unlock Blimps", Unlocker.UnlockBlimp, delegate (bool x) { Unlocker.UnlockBlimp = x; });
            TransportGroup.AddCheckbox("Unlock Sightseeing Bus", Unlocker.UnlockSightseeingBus, delegate (bool x) { Unlocker.UnlockSightseeingBus = x; });
            TransportGroup.AddCheckbox("Unlock Walking Tour", Unlocker.UnlockWalkingTour, delegate (bool x) { Unlocker.UnlockWalkingTour = x; });
            #endregion
        }

        private static UIButton AddTab(UITabstrip tabStrip, string title)
        {
            UIButton tabButton = tabStrip.AddTab(title);

            tabButton.normalBgSprite = "SubBarButtonBase";
            tabButton.disabledBgSprite = "SubBarButtonBaseDisabled";
            tabButton.focusedBgSprite = "SubBarButtonBaseFocused";
            tabButton.hoveredBgSprite = "SubBarButtonBaseHovered";
            tabButton.pressedBgSprite = "SubBarButtonBasePressed";

            tabButton.textPadding = new RectOffset(10, 10, 10, 10);
            tabButton.autoSize = true;
            tabButton.tooltip = title;

            return tabButton;
        }
    }
}
