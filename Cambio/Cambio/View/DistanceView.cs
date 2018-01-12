using Cambio.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cambio.View
{
    public class DistanceView
    {
        public DistanceView(MainView parent)
        {
            Parent = parent;
            Controller = Parent.Controller;

            MainPage = NewDistancePage();
            Controller.GoTo(MainPage);

        }

        public ContentPage NewDistancePage()
        { 
            Button back = new Button();
            Entry meter = new Entry();
            Entry inch = new Entry();

            back.HorizontalOptions = LayoutOptions.Start;
            back.Text = "Back";
            back.Clicked += (o, e) => Parent.GoToMainPage();
            
            meter.HorizontalTextAlignment = TextAlignment.Center;
            meter.VerticalOptions = LayoutOptions.Center; 
            // TODO Fill width
            meter.TextChanged += (o, e) => inch.Text = "0";

            inch.HorizontalTextAlignment = TextAlignment.Center;
            inch.VerticalOptions = LayoutOptions.Center;
            inch.TextChanged += (o, e) => meter.Text = "0";

            return new ContentPage
            {
                // TODO Use Grid layout
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Convert Distances"
                        },
                        // IDEA Create method to create these lines
                        new StackLayout { 
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
                                new Label {
                                    HorizontalTextAlignment = TextAlignment.Center,
                                    VerticalTextAlignment = TextAlignment.Center,
                                    Text = "Meters"
                                },
                                meter
                            }
                        },
                        new StackLayout {
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
                                new Label {
                                    HorizontalTextAlignment = TextAlignment.Center,
                                    VerticalTextAlignment = TextAlignment.Center,
                                    Text = "Inches"
                                },
                                inch
                            }
                        },
                        back
                    }
                }
            };
        }

        public MainView Parent { get; private set; }
        public ContentPage MainPage { get; private set; }
        public MainController Controller { get; private set; }
    }
}
