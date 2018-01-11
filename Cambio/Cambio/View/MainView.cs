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
            distance.HorizontalOptions = LayoutOptions.Start;
            distance.Text = "Distance";
            distance.Clicked += (o, e) => this.GoToDistancePage();

            return new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "CAMBIO"
                        },
                        distance
                    }
                }
            };
        }

        protected ContentPage NewDistancePage()
        {
            Button back = new Button();
            back.HorizontalOptions = LayoutOptions.Start;
            back.Text = "Back";
            back.Clicked += (o, e) => this.GoToMainPage();

            return new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children =
                    {
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Convert Distances"
                        },
                        back
                    }
                }
            };
        }
        #endregion

        #region Go-to Methods
        protected void GoToMainPage()
        {
            Controller.GoTo(NewMainPage());
        }

        protected void GoToDistancePage()
        {
            Controller.GoTo(NewDistancePage());
        }
        #endregion

        #region Properties
        protected MainController Controller;
        public ContentPage MainPage;
        #endregion
    }
}
