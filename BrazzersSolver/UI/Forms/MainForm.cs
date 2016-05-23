using System.Windows.Forms;
using BrazzersSolver.Core.Helpers;

namespace BrazzersSolver.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetRnKey_Click(object sender, System.EventArgs e)
        {
            tbRnKey.Text = BrazzerParseHelper.GetRnKey(rtbSource.Text);
        }
    }
}