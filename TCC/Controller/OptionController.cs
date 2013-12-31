using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.View;

namespace TCC.Controller.Factory
{
    public class OptionController : FormControllerBase
    {
        public OptionController()
        {
            Option view = new Option();
            this.Form = view;
            InitializeButtonsEvents(view);
        }

        private void InitializeButtonsEvents(Option view)
        {
           
        }

        void rrr_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            FrontController.Instance.ChangeCurrentController<HomeController>(true);
        }


    }
}
