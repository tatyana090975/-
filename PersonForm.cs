using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дипломная_работа
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void createRecordButton_Click(object sender, EventArgs e)
        {
            PersonCardForm form = new PersonCardForm();
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GeneralForm generalForm = new GeneralForm();
            generalForm.ShowDialog();
        }
    }
}
