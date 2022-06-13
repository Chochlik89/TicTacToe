using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolkokrzyzyk
{
    static class GetPlayerPrompt
    {
        public static string ShowDialog()
        {
            Form prompt = new GetPlayerPromptForm();

            Button acceptButton = (Button)prompt.Controls["button1"];
            prompt.AcceptButton = acceptButton;

            DialogResult result = prompt.ShowDialog();

            if(result == DialogResult.OK)
            {
                string text = prompt.Controls["textBox1"].Text;
                return text;
            }
            else
            {
                return "";
            }

            //return prompt.ShowDialog() == DialogResult.OK ? prompt.Controls["textBox1"].Text : "";
        }
    }
}
