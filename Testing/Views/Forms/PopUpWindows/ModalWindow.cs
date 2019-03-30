using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Domain.Controllers;
using Testing.Models;

namespace Testing.Views.Forms
{
    public partial class ModalWindow : Form
    {
        public bool Answer { get; private set; }
        public ModalWindow()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Answer = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Answer = false;
            this.Close();
        }
        private void DialogWindow_Load(object sender, EventArgs e)
        {
        }
    }
}
