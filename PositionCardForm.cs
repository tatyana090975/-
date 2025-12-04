using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дипломная_работа
{
    public partial class PositionCardForm : Form
    {
        public PositionCardForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string positionName = positionTextBox.Text;
            if (positionName == "")
            {
                MessageBox.Show("Заполните наименование должности!");
            }
            else
            {                
                string res = DBQueries.SavePositionCard(positionName);
                MessageBox.Show(res);
                Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            PositionForm positionForm = new PositionForm();
        }
    }
}
