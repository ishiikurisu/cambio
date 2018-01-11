using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Cambio.View;
using Cambio.Controller;

namespace Cambio
{
    public class App : Application
    {
        public App()
        {
            MainController controller = new MainController(this);
            MainView view = new MainView(controller);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
