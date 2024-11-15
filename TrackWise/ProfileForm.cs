using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace TrackWise
{
    public partial class ProfileForm : Form
    {
        private UserProfile _userProfile;

        public ProfileForm()
        {
            InitializeComponent();
            LoadUserProfile();
            DisplayUserProfile();
        }

        private void LoadUserProfile()
        {
            string filePath = "userProfile.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                _userProfile = JsonConvert.DeserializeObject<UserProfile>(json);
            }
            else
            {
                _userProfile = new UserProfile(); // Load default values if no profile found
            }
        }

        private void DisplayUserProfile()
        {
            lblUsername.Text = _userProfile.Username;
            lblEmail.Text = _userProfile.Email;
            cbFontSize.SelectedItem = _userProfile.FontSize.ToString();
            cbFontStyle.SelectedItem = _userProfile.FontStyle;
            cbTheme.SelectedItem = _userProfile.Theme;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            _userProfile.FontSize = int.Parse(cbFontSize.SelectedItem.ToString());
            _userProfile.FontStyle = cbFontStyle.SelectedItem.ToString();
            _userProfile.Theme = cbTheme.SelectedItem.ToString();

            SaveUserProfile();
            MessageBox.Show("Profile updated successfully!");
        }

        private void SaveUserProfile()
        {
            string json = JsonConvert.SerializeObject(_userProfile, Formatting.Indented);
            File.WriteAllText("userProfile.json", json);
        }
    }
}
