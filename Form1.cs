using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeRasbianV1._1
{
    public partial class CleanOS : Form
    {
        private Control[] startControls = new Control[10];

        #region ctor
        public CleanOS()
        {
            InitializeComponent();
            ContentPanel.Controls.CopyTo(startControls,0);
        }
        #endregion

        #region help methods

        public static void Navigation(Form form, ref Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
        #endregion

        #region buttons methods
        private void HomeButton_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.AddRange(startControls);
        }

        private void CleanboxButton1_Click(object sender, EventArgs e)
        {
            var cleanbox = new Cleanbox();
            Navigation(cleanbox, ref ContentPanel);
        }
        #endregion
    }
}
