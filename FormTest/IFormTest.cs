using System;
namespace FormTest
{
    public interface IFormTest
    {
        void AddFeature(FeaturePair pair);
        FeaturePair FindFeature(string AutomationId);

        string GetProperty(string AutomationIdDotProperty);

        void PushPage(string automationId);
        void PopPage(string automationId);
    }
}
