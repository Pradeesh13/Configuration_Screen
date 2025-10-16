using ConfigurationScreen.Utility;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ConfigurationScreen.UserControls.UserConfiguration
{
    public partial class UserConfigurationScreen : UserControl
    {
        private List<UserConfigurationParameters> Users = new List<UserConfigurationParameters>();
        Ini IniFile = new Ini("E:\\Projects\\C#\\Configuration_Screen\\Info\\UserConfig.ini");

        public UserConfigurationScreen()
        {
            InitializeComponent();

            DisableControls();
        }


        private void AddUser_picbox_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName_txtbox.Text))
            {
                MessageBox.Show("Please enter the user name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Password_txtbox.Text == ConfirmPassword_txtbox.Text)
                {
                    if (!string.IsNullOrWhiteSpace(Password_txtbox.Text) && !string.IsNullOrWhiteSpace(ConfirmPassword_txtbox.Text))
                    {
                        AddUser();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the same password for both.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void NewFile_picbox_Click(object sender, EventArgs e)
        {
            ClearControlInputs();

            EnableControls();
        }

        private void EnableControls()
        {
            UserLevel_cmbbox.Enabled = true;
            UserName_txtbox.Enabled = true;
            Password_txtbox.Enabled = true;
            ConfirmPassword_txtbox.Enabled = true;
        }

        private void DisableControls()
        {
            UserLevel_cmbbox.Enabled = false;
            UserName_txtbox.Enabled = false;
            Password_txtbox.Enabled = false;
            ConfirmPassword_txtbox.Enabled = false;
        }

        private void ClearControlInputs()
        {
            UserLevel_cmbbox.SelectedIndex = -1;
            UserName_txtbox.Text = string.Empty;
            Password_txtbox.Text = string.Empty;
            ConfirmPassword_txtbox.Text = string.Empty;
        }

        private void AddUser()
        {
            UserConfigurationParameters NewUser = new UserConfigurationParameters
            {
                UserLevel = UserLevel_cmbbox.SelectedItem?.ToString(),
                UserName = UserName_txtbox.Text,
                Password = Password_txtbox.Text,
                ConfirmPassword = ConfirmPassword_txtbox.Text,
            };

            Users.Add(NewUser);

            UserList_grid.Rows.Add(NewUser.UserName);

            Writeini();

            ClearControlInputs();

            DisableControls();
        }

        private void UserList_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UserConfigurationParameters SelectedUsers = Users[e.RowIndex];

                UserLevel_cmbbox.SelectedItem = SelectedUsers.UserLevel;
                UserName_txtbox.Text = SelectedUsers.UserName;
                Password_txtbox.Text = SelectedUsers.Password;
                ConfirmPassword_txtbox.Text = SelectedUsers.ConfirmPassword;

                EnableControls();
            }
        }

        private void UpdateUser_picbox_Click(object sender, EventArgs e)
        {
            if (UserList_grid.Rows.Count == 1)
            {
                try
                {
                    int rowIndex = UserList_grid.SelectedRows[0].Index;
                    UserConfigurationParameters User = Users[rowIndex];

                    User.UserLevel = UserLevel_cmbbox.SelectedItem?.ToString();
                    User.UserName = UserName_txtbox.Text;
                    User.Password = Password_txtbox.Text;
                    User.ConfirmPassword = ConfirmPassword_txtbox.Text;

                    UserList_grid.Rows[rowIndex].Cells[0].Value = User.UserName;

                    MessageBox.Show("Updated Successfully.", "Update", MessageBoxButtons.OK);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Please select one user update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select one user update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoveUser_picbox_Click(object sender, EventArgs e)
        {
            if (UserList_grid.SelectedRows.Count == 1)
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected device?", "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = UserList_grid.SelectedRows[0].Index;
                    Users.RemoveAt(rowIndex);
                    UserList_grid.Rows.RemoveAt(rowIndex);

                    DeleteUser();

                    ClearControlInputs();
                }
            }
            else if (UserList_grid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one user at a time.", "Multiple Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a user to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Writeini()
        {
            string user_txt = UserLevel_cmbbox.SelectedItem?.ToString();
            string UserName_txt = UserName_txtbox.Text;
            string Password_txt = Password_txtbox.Text;

            IniFile.WriteValue(UserName_txt, user_txt, Password_txt);

            IniFile.Save();
        }

        private void DeleteUser()
        {
            IniFile.DeleteKey(UserName_txtbox.Text, UserLevel_cmbbox.SelectedItem?.ToString(), Password_txtbox.Text);
        }
    }
}
