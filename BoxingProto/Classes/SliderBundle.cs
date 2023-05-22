using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BoxingProto.Classes
{
    public class SliderBundle
    {

        public Slider slider = new Xamarin.Forms.Slider();
        public Label descriptionLabel = new Label();
        public Label percentageLabel = new Label();
        public Label valueLabel = new Label();

        public SliderBundle()
        {

        }

        public void HideBundle()
        {
            slider.IsVisible= false;
            descriptionLabel.IsVisible= false;
            percentageLabel.IsVisible= false;
            valueLabel.IsVisible= false;
            slider.Value = 0;
        }

        public void ShowBundle()
        {
            slider.IsVisible = true;
            descriptionLabel.IsVisible = true;
            percentageLabel.IsVisible = true;
            valueLabel.IsVisible = true;
        }
    }
}
