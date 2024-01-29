using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweeper
{
    public partial class ExtensionDialog : Form
    {
        private SweeperControlView parent;

        public ExtensionDialog(SweeperControlView parent, string? extension, string? path, bool? update = false)
        {
            InitializeComponent();
            this.parent = parent;
            if (extension != null) textboxExtension.Text = extension;
            if (path != null) textboxPath.Text = path;
            if (update == true) buttonConfirm.Text = "Update";
        }

        public ExtensionDialog(SweeperControlView parent) : this(parent, null, null, false)
        {
          
        }

        private void ExtensionDialog_Load(object sender, EventArgs e)
        {

        }

        private void textboxExtension_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> extensions = parent.Model.Extensions;
            if (extensions.ContainsKey(textboxExtension.Text))
            {
                if (textboxPath.Text == "")
                {
                    textboxPath.Text = extensions[textboxExtension.Text];
                }
                buttonConfirm.Text = "Update";
            }
            else
            {
                buttonConfirm.Text = "Add";
            }
        }

        public string getFormattedExtensionString()
        {
            if(textboxExtension.Text.StartsWith(".")) return textboxExtension.Text;
            else return "." + textboxExtension.Text;
        }

        public string getFormattedPathString()
        {
            if (textboxPath.Text.StartsWith("/")) return textboxPath.Text;
            else return "/" + textboxPath.Text;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            parent.addOrUpdateExtension(getFormattedExtensionString(), getFormattedPathString());
            Close();
            Dispose();
        }
    }
}
