using System;

using Xamarin.Forms;

namespace FormTest
{
    public class Page : ContentPage
    {
        public Page()
        {
        }
		protected override void OnAppearing()
		{
            base.OnAppearing();
            DependencyService.Get<IFormTest>()?.PushPage(AutomationId);
		}
		protected override void OnDisappearing()
		{
            base.OnDisappearing();
            DependencyService.Get<IFormTest>()?.PopPage(AutomationId);
		}
	}
}

