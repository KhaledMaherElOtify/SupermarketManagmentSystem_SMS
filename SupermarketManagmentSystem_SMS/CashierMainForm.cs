﻿using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using SupermarketManagmentSystem_SMS.UserControls;

namespace SupermarketManagmentSystem_SMS
{
    public partial class CashierMainForm : Form
    {
        private readonly ApplicationDbContext dbcontext;
        public User CurrentUser {private get; set; }

        public CashierMainForm()
        {
            InitializeComponent();
            dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);
        }

        public void LoadPage(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(page);
        }
        private void Logout()
        {
            if (MessageBox.Show("هل تريد تسجيل الخروج؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ProductsAndCategoriesBtn_Click(object sender, EventArgs e)
        {
            //LoadPage(new AddProductControl());
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            var uc = new CashierSales(dbcontext ,CurrentUser);
            LoadPage(uc);
        }
    }
}

