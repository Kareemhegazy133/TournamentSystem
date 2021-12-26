using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLibrary;
using SystemLibrary.Models;

namespace SystemUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PlayerModel> availableTeamMembers = GlobalConfig.Connection.GetPlayers_All();
        private List<PlayerModel> selectedTeamMembers = new List<PlayerModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PlayerModel { FirstName = "Kareem", LastName = "Hegazy" });
            availableTeamMembers.Add(new PlayerModel { FirstName = "Test", LastName = "Test2" });

            selectedTeamMembers.Add(new PlayerModel { FirstName = "Test3", LastName = "Test4" });
            selectedTeamMembers.Add(new PlayerModel { FirstName = "Test5", LastName = "Test6" });
        }

        private void WireUpLists()
        {
            //selectTeamMemberDropDown.Refresh();
            //teamMembersListBox.Refresh();

            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PlayerModel p = new PlayerModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                
                p = GlobalConfig.Connection.CreatePlayer(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
                
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private bool ValidateForm()
        {
            if(firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if(lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if(emailValue.Text.Length == 0)
            {
                return false;
            }

            if(cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PlayerModel p = (PlayerModel)selectTeamMemberDropDown.SelectedItem;

            if(p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void removeSelectedTeamMemberButton_Click(object sender, EventArgs e)
        {
            PlayerModel p = (PlayerModel)teamMembersListBox.SelectedItem;
            
            if(p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            // TODO - If we aren't closing this form after creation, reset the form
        }
    }
}
