using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Test
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Grid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection() { new RowDefinition() { Height = GridLength.Star } },
                ColumnDefinitions = new ColumnDefinitionCollection() { new ColumnDefinition() { Width = GridLength.Star } },
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                ColumnSpacing = 0,
                RowSpacing = 0,
            };
        }

        Grid Grid { get; set; }
        bool IsGridSet;
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == ContentProperty.PropertyName && Content != null)
            {
                if (!IsGridSet)
                {
                    //IsGridSet = true;
                    //Grid.Children.Add(Content);
                    //Content = Grid;
                }
            }
        }
    }
}
