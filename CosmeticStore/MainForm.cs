using CosmeticStore.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticStore
{
    public partial class MainForm : Form
    {
        private FormHome formHome;
        private FormBill formBill;
        private FormCustomer formCustomer;
        private FormProduct formProduct;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flpSidebar.Width -= 6;
                if (flpSidebar.Width <= 52)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnHome.Width = flpSidebar.Width;
                    pnBilling.Width = flpSidebar.Width;
                    pnCustomer.Width = flpSidebar.Width;
                    pnProduct.Width = flpSidebar.Width;
                    pnLogout.Width = flpSidebar.Width;
                    //mdiManager.AdjustChildForms();
                }
            }
            else
            {
                flpSidebar.Width += 6;
                if (flpSidebar.Width >= 141)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    pnHome.Width = flpSidebar.Width;
                    pnBilling.Width = flpSidebar.Width;
                    pnCustomer.Width = flpSidebar.Width;
                    pnProduct.Width = flpSidebar.Width;
                    pnLogout.Width = flpSidebar.Width;
                    //mdiManager.AdjustChildForms();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (formHome == null)
            {
                formHome = new FormHome();
                formHome.FormClosed += FormHome_FormClosed;
                formHome.MdiParent = this;
                formHome.Dock = DockStyle.Fill;
                formHome.Show();
            } else
            {
                formHome.Activate();
            }
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHome = null;
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            if (formBill == null)
            {
                formBill = new FormBill();
                formBill.FormClosed += FormBill_FormClosed;
                formBill.MdiParent = this;
                formBill.Dock = DockStyle.Fill;
                formBill.Show();
            }
            else
            {
                formBill.Activate();
            }
        }

        private void FormBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHome = null;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (formCustomer == null)
            {
                formCustomer = new FormCustomer();
                formCustomer.FormClosed += FormCustomer_FormClosed;
                formCustomer.MdiParent = this;
                formCustomer.Dock = DockStyle.Fill;
                formCustomer.Show();
            }
            else
            {
                formCustomer.Activate();
            }
        }

        private void FormCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHome = null;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (formProduct == null)
            {
                formProduct = new FormProduct();
                formProduct.FormClosed += FormProduct_FormClosed;
                formProduct.MdiParent = this;
                formProduct.Dock = DockStyle.Fill;
                formProduct.Show();
            }
            else
            {
                formProduct.Activate();
            }
        }

        private void FormProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHome = null;
        }
    }
}
