using System.Windows;
using System.Windows.Controls;

namespace FoodRecipeApp_24.View.UserControls
{
    
    public partial class MenuBarView : System.Windows.Controls.UserControl
    {
        public event EventHandler<string> ButtonClicked;

        public MenuBarView()
        {
            DataContext = this;
            InitializeComponent();

            foreach (var child in LogicalTreeHelper.GetChildren(this))
            {
                if (child is System.Windows.Controls.Button button)
                {
                    button.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button? button = sender as System.Windows.Controls.Button;
            string? pageName = (string)button.Tag;

            // Invoke the corresponding event handler based on the pageName
            switch (pageName)
            {
                case "prof":
                    Profile_Click(sender, e);
                    break;
                case "fridge":
                    MyFridge_Click(sender, e);
                    break;
                case "fav":
                    Myfavourites_Click(sender, e);
                    break;

                case "addRecipe":
                    AddRecipe_Click(sender, e);
                    break;

                case "faqs":
                    FAQs_Click(sender, e);
                    break;

                case "stngs":
                    Settings_Click(sender, e);
                    break;

                case "abt":
                    AboutUs_Click(sender, e);
                    break;

                case "revs":
                    Reviews_Click(sender, e);
                    break;

                default:
                    break;
            }
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked?.Invoke(this, "prof");
        }

        private void MyFridge_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked?.Invoke(this, "fridge");
        }

        private void Myfavourites_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked?.Invoke(this, "fav");
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked?.Invoke(this, "addRecipe");
        }

        private void FAQs_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked?.Invoke(this, "faqs");
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked?.Invoke(this, "stngs");
        }

        private void AboutUs_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked?.Invoke(this, "abt");
        }

        private void Reviews_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked?.Invoke(this, "revs");
        }
    }
}
