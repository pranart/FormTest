﻿using System;
using Xamarin.Forms;

namespace FormTest
{
#if DEBUG
    public class Image : Xamarin.Forms.Image, IPropertyGet
    {
        public Image()
        {
            DependencyService.Get<IFormTest>()?.AddFeature(new FeaturePair(GetAutomationId, GetProperty));
        }
        public string GetAutomationId()
        {
            return AutomationId;
        }
        public IPropertyGet GetProperty()
        {
            return this;
        }
        public string Get(string propertyName)
        {
            switch (propertyName)
            {
                //ELEMENT
                case nameof(ClassId):
                    return ClassId.ToString();
                case nameof(AutomationId):
                    return AutomationId.ToString();
                case nameof(Id):
                    return Id.ToString();
                case nameof(StyleId):
                    return StyleId.ToString();
                //VISUAL ELEMENT
                case nameof(AnchorX):
                    return AnchorX.ToString();
                case nameof(AnchorY):
                    return AnchorY.ToString();
                case nameof(BackgroundColor):
                    return BackgroundColor.ToHex();
                case nameof(Width):
                    return this.Width.ToString();
                case nameof(Height):
                    return this.Height.ToString();
                case nameof(IsEnabled):
                    return IsEnabled.ToString();
                case nameof(WidthRequest):
                    return this.WidthRequest.ToString();
                case nameof(HeightRequest):
                    return this.HeightRequest.ToString();
                case nameof(IsFocused):
                    return IsFocused.ToString();
                case nameof(IsVisible):
                    return IsVisible.ToString();
                case nameof(InputTransparent):
                    return InputTransparent.ToString();
                case nameof(X):
                    return this.X.ToString();
                case nameof(Y):
                    return this.Y.ToString();
                case nameof(Opacity):
                    return this.Opacity.ToString();
                case nameof(TranslationX):
                    return this.TranslationX.ToString();
                case nameof(TranslationY):
                    return this.TranslationY.ToString();
                case nameof(Rotation):
                    return this.Rotation.ToString();
                case nameof(RotationX):
                    return this.RotationX.ToString();
                case nameof(RotationY):
                    return this.RotationY.ToString();
                case nameof(Scale):
                    return this.Scale.ToString();
                //VIEW
                case nameof(Margin):
                    return this.Margin.ToString();
                case nameof(VerticalOptions):
                    return this.VerticalOptions.ToString();
                case nameof(HorizontalOptions):
                    return this.HorizontalOptions.ToString();

                //IMAGE
                case nameof(Source):
                    switch (Source)
                    {
                        case FileImageSource file:
                            return file.File;
                        case UriImageSource uri:
                            return uri.Uri.ToString();
                        default:
                            return string.Empty;
                    }
                case nameof(Aspect):
                    return this.Aspect.ToString();
                case nameof(IsOpaque):
                    return this.IsOpaque.ToString();

                default:
                    return string.Empty;

            }
        }
    }
#else
    public class Image : Xamarin.Forms.Image
    {
    }
#endif
}