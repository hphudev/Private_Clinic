using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DAO;
using System.Threading;
using GUI.Properties;

namespace GUI
{
    public partial class FormSplash : Form
    {
        int timeSleep = 0;
        public FormSplash()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += LoadForm;
            this.bReConnectServer.Click += Clicked_bReconnectServer;
            this.KeyDown += ExitForm;
            BUS.EventHandler.openEye = Resources.OpenEye; 
            BUS.EventHandler.closeEye = Resources.CloseEye;
            this.MouseDown += (s, e) =>
            {
                BUS.EventHandler.MouseDown_DragBar(this);
            };
        }

        private void LoadForm(object s, EventArgs e)
        {
            BUS.EventHandler.ShowFormEffect(this, 1);
            Clicked_bReconnectServer(this, new EventArgs());
        }

        private async void Clicked_bReconnectServer(object s, EventArgs e)
        {
            this.pBar.Visible = true;
            this.lDisconnecting.Visible = false;
            this.bReConnectServer.Visible = false;
            this.lRecommend.Visible = false;
            timeSleep += 5000;
            await DAO.DataHandler.OpenConnection(this.pBar);
            if (this.pBar.Value == 5)
            {
                await BUS.EventHandler.FreezeForm(timeSleep);
                this.bReConnectServer.Visible = true;
                this.lRecommend.Visible = true;
                this.pBar.Visible = false;
                this.lDisconnecting.Visible = true;
                this.pBar.Value = 0;
            }
            else
            {
                this.pBar.Value += 90;
                await BUS.EventHandler.FreezeForm(2000);
                BUS.EventHandler.ShowChildForm_HideParentForm(new FormEntrance(this), this);
            }
            return;
        }

        private void ExitForm(object s, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                BUS.EventHandler.HideFormEffect(this, 1, true);
        }
    }
}
