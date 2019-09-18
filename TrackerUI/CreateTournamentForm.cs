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
    public partial class CreateTournamentForm : Form , IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams =  GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpList();
        }

        private void WireUpList()
        {
            selectTeamDropDown.DataSource = null;

            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tornamentTeamsListBox.DataSource = null;

            tornamentTeamsListBox.DataSource = selectedTeams;
            tornamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addteamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpList();
            }
        }

        private void deleteSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tornamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpList();
            }
        }

        private void deleteSelectedPricesButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);
                
                WireUpList();
            }
        }


        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //call the create prize form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpList();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpList();
        }

        private void createNewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();

        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {

            //validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Create tournament model
            TournamentModel tm = new TournamentModel
                {
            TournamentName = tournamentNameValue.Text,
            EntryFee = fee,
            Prizes = selectedPrizes,
            EnteredTeams = selectedTeams,
                };


            //WireUp our matchups

            //Create tournament entry
            //Create all the prices entries
            //Create al team entries
            GlobalConfig.Connection.CreateTournament(tm);

            //Create our matchups


        }
    }
}
