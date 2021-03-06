﻿using System;
using System.Collections.Generic;
using FormTest;
using Xamarin.Forms;

[assembly: Dependency(typeof(FormTest.Droid.TheFormTest))]
namespace FormTest.Droid
{
    public class TheFormTest : FormTest.IFormTest
    {
        public List<FeaturePair> Features;

        public TheFormTest()
        {
            Features = new List<FeaturePair>();
        }

        public void AddFeature(FeaturePair pair)
        {
            Features.Add(pair);
        }

        public FeaturePair FindFeature(string AutomationId)
        {
            foreach (FeaturePair featurePair in Features)
            {
                if (featurePair.GetAutomationId() == AutomationId)
                {
                    return featurePair;
                }
            }
            return null;
        }

        public string GetProperty(string AutomationIdDotProperty)
        {
            string[] parts = AutomationIdDotProperty.Split('.');
            FeaturePair feature = FindFeature(parts[0]);
            if (feature != null)
            {
                return feature.GetProperty().Get(parts[1]);
            }
            return null;
        }

        public void PopPage(string automationId)
        {

        }

        public void PushPage(string automationId)
        {

        }

    }
}
