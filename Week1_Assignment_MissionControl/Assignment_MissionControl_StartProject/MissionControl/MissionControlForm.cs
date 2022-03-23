using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionControl
{
    public partial class MissionControlForm : Form
    {
        private MissionControl missionControl;

        public MissionControlForm()
        {
            InitializeComponent();
            missionControl = new MissionControl();
        }

        private void btAddAstronaut_Click(object sender, EventArgs e)
        {
            string name = tbAstronautName.Text;
            string gender = cbAstronautGender.Text;
            string nationality = tbAstronautNationality.Text;
            missionControl.AddAstronaut(name, gender, nationality);

            // Add name of astronaut to combo boxes
            cbAstronauts.Items.Add(name);
            cbAstronautDetails.Items.Add(name);
        }

        private void btAddMission_Click(object sender, EventArgs e)
        {
            string name = tbMissionName.Text;
            DateTime launchDate = Convert.ToDateTime(dtpLaunchDate.Text);
            DateTime returnDate = Convert.ToDateTime(dtpReturnDate.Text);
            string spaceship = tbSpaceship.Text;
            missionControl.AddMission(name, launchDate, returnDate, spaceship);

            // Add mission name to combo box
            cbMissions.Items.Add(name);
        }

        private void btShowAllMissions_Click(object sender, EventArgs e)
        {
            lbMissions.Items.Clear();
            foreach(string s in missionControl.GetAllMissions())
            {
                lbMissions.Items.Add(s);
            }
        }

        private void btShowAstronautDetails_Click(object sender, EventArgs e)
        {
            string astronautName = cbAstronautDetails.SelectedItem.ToString();
            Astronaut a = missionControl.GetAstronautByName(astronautName);
            if (a != null)
            {
                // display information in GUI

                lbMissionHistory.Items.Clear();
                List<Mission> missions = a.GetAllMissions();
                foreach(Mission m in missions)
                {
                    lbMissionHistory.Items.Add(m.ToString());
                }

                tbDaysInSpace.Text = a.GetDaysInSpace().ToString();
                tbLongestMission.Text = a.GetLongestMission();

                lbTravelCompanions.Items.Clear();
                List<string> companions = a.GetCompanions();
                foreach (string companion in companions)
                {
                    lbTravelCompanions.Items.Add(companion);
                }

 
            }
            else
            {
                MessageBox.Show("Astronaut with name " + astronautName + " not found");
            }

        }

        private void btAssign_Click(object sender, EventArgs e)
        {
            string astronautName = cbAstronauts.SelectedItem.ToString();
            Astronaut a = missionControl.GetAstronautByName(astronautName);

            string missionName = cbMissions.SelectedItem.ToString();
            Mission m = missionControl.GetMissionByName(missionName);

            bool success = missionControl.AssignToMission(a, m);
            if (success)
                MessageBox.Show("Astronaut " + astronautName + " successfully added");
            else
                MessageBox.Show("Astronaut " + astronautName + " could not be added");
        }
    }
}
