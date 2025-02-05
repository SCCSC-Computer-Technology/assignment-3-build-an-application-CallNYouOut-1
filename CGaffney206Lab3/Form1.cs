﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGaffney206Lab3
{
    // CPT-206
    // Lab 3 Part II: Electric Boogaloo
    // Colin Gaffney 


    // Had a rough week. Can't do this shit.



    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Pulling info form the database
            StatesDBDataContext db = new StatesDBDataContext();
                          
            // Generating a list of all states into the listbox
            foreach (State item in db.States)
            {
                lstbxStates.Items.Add(item.State1.ToString());
            }
        }

        private void btnDetails_Click(object sender, EventArgs e) // Hides main menu and shows state's details
        {
            try
            {
                this.Hide();
                frmStateDetails stateDetails = new frmStateDetails(lstbxStates.SelectedIndex, this);
                stateDetails.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Make sure to select a state.");
            }
        }

        private void btnDatabase_Click(object sender, EventArgs e) // Hides main menu and shows database
        {
            this.Hide();
            frmDataMenu stateDB = new frmDataMenu(this);
            stateDB.ShowDialog();
        }
    }
}
