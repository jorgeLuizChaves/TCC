using MyComponents.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for Option.xaml
    /// </summary>
    public partial class Option : ContentForm
    {
        public Option()
        {
            InitializeComponent();
            //var track = kinectSlider.Template.FindName("PART_Track", kinectSlider) as Track;
            //track.Thumb.DragCompleted += Thumb_DragCompleted;
        }

        void Thumb_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            Console.WriteLine("value: " + kinectSlider.Value);
        }



    }
}
