﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Participation
{
    public partial class Form_MainVolunteer : Form
    {
        Volunteer currentuser;
        VolunteerHandler volunteerhandler;
        public Form_MainVolunteer(User loggedinasuser)
        {
            InitializeComponent();
            currentuser = loggedinasuser as Volunteer;
            lbl_UserName.Text = currentuser.Name;
            volunteerhandler = new VolunteerHandler();
            RefreshInterface();
        }

        private void Form_Volunteer_Load(object sender, EventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Form_Profile profiledialog = new Form_Profile(currentuser);
            this.Hide();
            profiledialog.ShowDialog();
            this.Show();
        }

        public void RefreshInterface()
        {
            lbox_Questions.Items.Clear();
            try
            {
                List<Question> questions = new List<Question>();
                lbox_Questions.Items.AddRange(volunteerhandler.GetQuestions().ToArray());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("er zijn geen questions");
            }
        }

        private void btn_Respond_Click(object sender, EventArgs e)
        {
            if (lbox_Questions.SelectedIndex != -1)
            {
                var foo = lbox_Questions.SelectedItem;
                Question question = foo as Question;
                Form_Question dialog = new Form_Question(question);
                this.Hide();
                dialog.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("U heeft geen vraag gekozen");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshInterface();
        }
    }
}
