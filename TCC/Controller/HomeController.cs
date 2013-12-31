using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Controller.Factory;
using TCC.View;

namespace TCC.Controller
{
    public class HomeController : FormControllerBase
    {
        public HomeController()
        {
            Home view = new Home();
            view.ConfigureButtons();
            this.Form = view;

            InitializeButtonsEvents(view);
        }

        private void InitializeButtonsEvents(Home view)
        {
            view.btnFisioterapeuta.Click += btnFisioterapeuta_Click;
            view.btnPaciente.Click +=btnPaciente_Click;
            view.btnExercicio.Click += btnExercicio_Click;
            view.btnOpcoes.Click += btnOpcoes_Click;
        }

        void btnOpcoes_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            FrontController.Instance.ChangeCurrentController<OptionController>(false);
        }

        private void btnExercicio_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            FrontController.Instance.ChangeCurrentController<OptionController>(false);
        }

        private void btnPaciente_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            FrontController.Instance.ChangeCurrentController<OptionController>(false);
        }

        private void btnFisioterapeuta_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            FrontController.Instance.ChangeCurrentController<OptionController>(false);
        }
    }
}
