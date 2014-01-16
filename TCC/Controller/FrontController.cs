using MyComponents.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Controller.Factory;
using TCC.View;
using Microsoft.Kinect;
using System.Windows.Controls.Primitives;

namespace TCC.Controller
{
    public class FrontController
    {
        #region [Atributtes]
        private static FrontController _instance;
        private FormControllerBase currentController;

        private bool _backEffect;

        #endregion

        #region[Properties]
        public static FrontController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrontController();
                return _instance;
            }
        }

        public ApplicationWindow Application
        {
            private set;
            get;
        }

        public FormControllerBase CurrentController
        {
            get { return currentController; }
            private set
            {
                SetCurrentController(ref currentController, value);
            }
        } 
        #endregion

        #region [Constructors]
        private FrontController() { }
        #endregion

        #region [Public's Methods]
        public void InicializeArchitecute(ApplicationWindow application)
        {
            this.Application = application;
            this.currentController = ControllerFactory.GetController<HomeController>();
            ContentForm view = this.currentController.GetView<Home>();
            OpenForm(view);
        }

        public void ChangeCurrentController<T>(bool backEffect = false) where T : FormControllerBase
        {
            _backEffect = backEffect;
            this.CurrentController = ControllerFactory.GetController<T>();
        }
        #endregion

        #region [Private's Methods]
        private void SetCurrentController(ref FormControllerBase currentController, FormControllerBase newController)
        {
            OpenControllerForm(newController);
        }

        private void OpenControllerForm(FormControllerBase newController)
        {
            if (_backEffect)
                this.BackToForm(newController.Form);
            else
                this.OpenForm(newController.Form);
        }

        private void OpenForm(ContentForm form)
        {
            this.Application.navigationPanel.ShowForm(form);
        }

        private void BackToForm(ContentForm form)
        {
            this.Application.navigationPanel.BackToForm(form);
        }
        #endregion

        public void slider_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            Console.Write("hi");
        }


    }
}
