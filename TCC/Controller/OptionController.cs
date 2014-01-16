using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using TCC.View;
using TCC.Extensions;
using System.Windows.Media;

namespace TCC.Controller.Factory
{
    public class OptionController : FormControllerBase
    {
        private Option view;

        public OptionController()
        {
            view = new Option();
            this.Form = view;
            InitializeButtonsEvents(view);
            view.lblVerticalValue.Content = Convert.ToInt32(view.kinectSlider.Value);
        }

        private void InitializeButtonsEvents(Option view)
        {
            view.kinectSlider.ValueChanged += kinectSlider_ValueChanged;

            view.btnVoltar.Foreground = Brushes.White;
            view.btnVoltar.Click += btnVoltar_Click;
        }

        void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            FrontController.Instance.ChangeCurrentController<HomeController>(true);
        }

        void kinectSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            view.lblVerticalValue.Content = Convert.ToInt32(view.kinectSlider.Value);
        }

    }
}
