﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        MessageCreation messageCreationForm;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void LaunchMessage_Click(object sender, EventArgs e)
        {
            messageCreationForm = new MessageCreation();
            messageCreationForm.StartPosition = FormStartPosition.Manual;
            messageCreationForm.Location = new Point(this.Location.X + 10, this.Location.Y + this.Height + 20);
            messageCreationForm.MessageCreated += MessageCreationForm_MessageCreated;
            messageCreationForm.Show();
        }

        private void MessageCreationForm_MessageCreated(object sender, MessageModelEventArgs e)
        {
            messageText.Text = e.message.Message;
            messageCreationForm.MessageCreated -= MessageCreationForm_MessageCreated;
        }

        private void LaunchSubDashboard_Click(object sender, EventArgs e)
        {
            SubDashboard subDashboardForm = new SubDashboard();
            subDashboardForm.Show();
        }
    }
}
