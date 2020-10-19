using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void cmbEnvironment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cmbEnvironment_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbEnvironment.Text.ToUpper())
            {
                case "DEVTEST":
                    btnBuild.Text = "Build and Deploy! (Test Branch)";
                    break;
                case "STAGING":
                    btnBuild.Text = "Build and Deploy! (Release Branch)";
                    break;
                case "PROD":
                    btnBuild.Text = "Release! (Release Branch)";
                    break;
            }
        }
    }
}
