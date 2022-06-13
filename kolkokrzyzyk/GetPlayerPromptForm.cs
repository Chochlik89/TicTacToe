using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolkokrzyzyk
{
    public partial class GetPlayerPromptForm : Form
    {
        public GetPlayerPromptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
