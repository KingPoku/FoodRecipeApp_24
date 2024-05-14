using FoodRecipeApp_24.View.UserControls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FoodRecipeApp_24.webPages
{
    public partial class UserProfile : Page
    {
        private string _usernameEmail;
        private ImageSource _profilePic;

        public event PropertyChangedEventHandler PropertyChanged;

        public string UsernameEmail
        {
            get { return _usernameEmail; }
            set
            {
                _usernameEmail = value;
                OnPropertyChanged();
            }
        }

        public ImageSource ProfilePic
        {
            get { return _profilePic; }
            set
            {
                if (_profilePic != value)
                {
                    _profilePic = value;
                    OnPropertyChanged_picEdit("ProfilePic");
                }
            }
        }
        public UserProfile()
        {
            InitializeComponent();
            DataContext = this;

        }

        private void EditPic_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProfilePic = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        protected virtual void OnPropertyChanged_picEdit([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            // Implement logout functionality here
        }

        private void DeleteMyAccount_Click(object sender, RoutedEventArgs e)
        {
            // Implement delete account functionality here
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void EditProfile_Click(object sender, RoutedEventArgs e)
        {
            View.UserControls.EditProfileWindow editProfileWindow = new EditProfileWindow();
            editProfileWindow.Owner = Window.GetWindow(this);
            editProfileWindow.ShowDialog();
        }
    }
}
