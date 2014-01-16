using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace TCC.Extensions
{
    public static class Extension
    {
        public static Thumb GetThumb(this Slider slider)
        {
            var track = slider.Template.FindName("PART_Track", slider) as Track;
            return track == null ? new Thumb() : track.Thumb;
        }
    }
}
