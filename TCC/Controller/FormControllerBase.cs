using MyComponents.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Controller
{
    public abstract class FormControllerBase
    {
        public ContentForm Form { get; protected set; }

        public T GetView<T>() where T : ContentForm
        {
            return (T)Form;
        }
    }
}
