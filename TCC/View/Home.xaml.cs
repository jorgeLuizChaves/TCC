using Microsoft.Kinect.Toolkit.Controls;
using MyComponents.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TCC.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : ContentForm
    {
        private List<KinectTileButton> kinectButtons;
        public Home()
        {
            InitializeComponent();

            CreateButtonsList();
        }

        private void CreateButtonsList()
        {
            kinectButtons = new List<KinectTileButton>();
            kinectButtons.Add(btnFisioterapeuta);
            kinectButtons.Add(btnPaciente);
            kinectButtons.Add(btnExercicio);
            kinectButtons.Add(btnOpcoes);
        }

        internal void ConfigureButtons()
        {
            FontFamily font = new FontFamily("Segoe UI Semibold");
            BrushConverter brushConverter = new BrushConverter();
            foreach (KinectTileButton button in this.kinectButtons)
            {
                button.Background = (Brush)brushConverter.ConvertFromString("#FF5F97F9");
                button.Foreground = Brushes.White;
                button.FontFamily = font;
                button.FontSize = 28d;
                
            }
        }
    }
}
