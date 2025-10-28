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
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }        
        //Открыть справочник "Приход товара"
        private void productReceipt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProductReseiptForm productReseiptForm = new ProductReseiptForm();
            productReseiptForm.Show();
        }
        //Открыть справочник "Наименования товаров"
        private void nameProductLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NameProductForm nameProductForm = new NameProductForm();
            nameProductForm.Show();
        }
        //Открыть справочник "Наименования услуг"
        private void nameServiceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NameServicesForm nameServicesForm = new NameServicesForm();
            nameServicesForm.Show();
        }
        //Открыть справочник "Продажные цены"
        private void salesPriceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SalesPriceForm salesPriceForm = new SalesPriceForm();
            salesPriceForm.Show();
        }
        //Открыть справочник "Складские остатки"
        private void stockLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            StorageForm storageForm = new StorageForm();
            storageForm.Show();
        }
        //Открыть справочник "Продажи товаров"
        private void saleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SaleForm saleForm = new SaleForm();
            saleForm.Show();
        }
        //Открыть справочник "Складские остатки"
        private void stockLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            StorageForm storageForm = new StorageForm();
            storageForm.Show();
        }
        //Открыть справочник "Пользователи"
        private void usersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }
        //Открыть справочник "Персоны"
        private void personLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PersonForm personForm = new PersonForm();
            personForm.Show();
        }
        //Открыть справочник "Должности"
        private void positionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PositionForm positionForm = new PositionForm();
            positionForm.Show();
        }
        //Открыть справочник "Работники"
        private void employeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EmployeForm employeForm = new EmployeForm();
            employeForm.Show();
        }
        //Открыть справочник "Контрагенты"
        private void partnerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PartnerForm partnerForm = new PartnerForm();
            partnerForm.Show();
        }
        //Открыть справочник "Покупатели"
        private void buyerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BuyerForm buyerForm = new BuyerForm();
            buyerForm.Show();
        }        
        //Выход со страницы (кнопка "Выход")
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
