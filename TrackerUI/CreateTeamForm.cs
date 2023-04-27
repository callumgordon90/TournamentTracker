using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        //available team members list and selected team members list
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        //this is a constructor which calls methods
        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }

        private void LoadListData()
        {
            availableTeamMembers = GlobalConfig.Connections.GetPerson_All();
        }

        private void CreateSampleData()
        {
            //this is sample data, only displayiong the first and last name:
            availableTeamMembers.Add(new PersonModel { FirstName = "Callum", LastName = "Gordon" });
            availableTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Smith" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jim", LastName = "Brown" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Edward", LastName = "Baker" });
        }

        // Now we create a method which wires the two lists up:
        private void WireUpLists()
        {
            selectTeamMemberDropdown.DataSource = null;

            selectTeamMemberDropdown.DataSource = availableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "Full Name";

            selectTeamMemberDropDown.Refresh();
        }

        private void createTournamentLabel_Click(object sender, EventArgs e)
        {

        }

        private void tournamentNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void tournamentNameValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                //Now that we have our model we need to send it to our database or text file
                GlobalConfig.Connection.CreatePerson(p);

                //Now finally we reset the values:
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields. ");
            }
        }


        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {

            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            //Here we are moving a team member from one place to another
            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            //WireUpLists();
            selectTeamMemberDropdown.Refresh();
            teamMembersListBox.Refresh();

        }

        private void removeSelectedMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            selectedTeamMembers.Remove(p);
            availableTeamMembers.Add(p);

            WireUpLists();

        }
    }
}
