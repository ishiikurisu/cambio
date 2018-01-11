using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cambio.Controller
{
    public class MainController
    {
        public MainController(Application app)
        {
            App = app;
        }

        public void GoTo(ContentPage page)
        {
            App.MainPage = page;
        }

        Application App;
    }
}
