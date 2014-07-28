﻿using System;
using System.ComponentModel;
using WinFormsMvp.Forms;

namespace LicenceTracker.Views
{
    public partial class LaunchView : MvpForm, ILaunchView
    {
        public LaunchView()
        {
            InitializeComponent();
        }

        public event EventHandler CloseFormClicked;
        public event EventHandler AddPersonClicked;
        public event EventHandler AddSoftwareClicked;
        public BindingList<LogEvent> LiveLog { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LogBindingSource.DataSource = LiveLog;
            lstLiveLog.DataSource = LogBindingSource;
        }

        public void Exit()
        {
            Close();
        }
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            CloseFormClicked(this, EventArgs.Empty);
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            AddPersonClicked(this, EventArgs.Empty);
        }
        

        public void ShowAddPersonView()
        {
            new AddPersonView().Show();
        }

        private void AddLicenceButton_Click(object sender, EventArgs e)
        {
            AddSoftwareClicked(this, EventArgs.Empty);
        }


        public void ShowAddProductView()
        {
            new AddProductView().Show();
        }

        private void AddSoftwareTypeButton_Click(object sender, EventArgs e)
        {
            new AddSoftwareType().Show();
        }
    }
}
