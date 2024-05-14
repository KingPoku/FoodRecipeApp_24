using System.Windows;
using System.Windows.Controls;

namespace FoodRecipeApp_24.View.UserControls
{
    public partial class EditProfileWindow : Window
    {
        public EditProfileWindow()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Save the changes to the user's profile
            string usernameEmail = UsernameEmailTextBox.Text;
            string password = PasswordBox.Password;

            // You can add your logic here to save the changes
            // For now, let's just close the window
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the window without saving changes
            Close();
        }
    }
}
