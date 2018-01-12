using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Cambio.Controller;

namespace Cambio.View
{
    public class MainView
    {
        #region Constructor
        public MainView(MainController controller)
        {
            Controller = controller;
            GoToMainPage();
        }
        #endregion

        #region New Methods
        protected ContentPage NewMainPage()
        {
            Button distance = new Button();
            distance.HorizontalOptions = LayoutOptions.Center;
            distance.Text = "\U00021950Distance";
            distance.Clicked += (o, e) => this.GoToDistancePage();

            return new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "CAMBIO\nWhat do you want to convert?"
                        },
                        distance
                    }
                }
            };
        }
        #endregion

        #region Go-to Methods
        public void GoToMainPage()
        {
            Controller.GoTo(NewMainPage());
        }

        public void GoToDistancePage()
        {
            DistanceView view = new DistanceView(this);
            Controller.GoTo(view.MainPage);
        }
        #endregion

        #region Properties
        public MainController Controller;
        public ContentPage MainPage;
        #endregion
    }
}
