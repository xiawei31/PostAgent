using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parthas.PostAgent
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        PostAgent GAgent;
        private void MainForm_Load(object sender, EventArgs e)
        {
            GAgent = new PostAgent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPostUrl.Text) && !string.IsNullOrEmpty(txtPostContent.Text))
            {
                try
                {
                    txtResponse.Text = GAgent.Post(txtPostUrl.Text, txtPostContent.Text);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GAgent.ResetCookie();
        }
    }
}
