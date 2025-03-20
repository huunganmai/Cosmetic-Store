namespace CosmeticStore
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnBilling = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.pnCustomer = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnProduct = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.flpSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.pnBilling.SuspendLayout();
            this.pnCustomer.SuspendLayout();
            this.pnProduct.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSidebar
            // 
            this.flpSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flpSidebar.Controls.Add(this.panel1);
            this.flpSidebar.Controls.Add(this.pnHome);
            this.flpSidebar.Controls.Add(this.pnBilling);
            this.flpSidebar.Controls.Add(this.pnCustomer);
            this.flpSidebar.Controls.Add(this.pnProduct);
            this.flpSidebar.Controls.Add(this.pnLogout);
            this.flpSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Size = new System.Drawing.Size(141, 605);
            this.flpSidebar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 55);
            this.panel1.TabIndex = 4;
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.btnHome);
            this.pnHome.Location = new System.Drawing.Point(3, 64);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(220, 62);
            this.pnHome.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-6, -10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(237, 80);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnBilling
            // 
            this.pnBilling.Controls.Add(this.btnBilling);
            this.pnBilling.Location = new System.Drawing.Point(3, 132);
            this.pnBilling.Name = "pnBilling";
            this.pnBilling.Size = new System.Drawing.Size(220, 60);
            this.pnBilling.TabIndex = 4;
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBilling.Image = ((System.Drawing.Image)(resources.GetObject("btnBilling.Image")));
            this.btnBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilling.Location = new System.Drawing.Point(-6, -11);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBilling.Size = new System.Drawing.Size(237, 80);
            this.btnBilling.TabIndex = 3;
            this.btnBilling.Text = "          Billing";
            this.btnBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // pnCustomer
            // 
            this.pnCustomer.Controls.Add(this.btnCustomer);
            this.pnCustomer.Location = new System.Drawing.Point(3, 198);
            this.pnCustomer.Name = "pnCustomer";
            this.pnCustomer.Size = new System.Drawing.Size(220, 60);
            this.pnCustomer.TabIndex = 4;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(-6, -12);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(237, 80);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "          Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnProduct
            // 
            this.pnProduct.Controls.Add(this.btnProduct);
            this.pnProduct.Location = new System.Drawing.Point(3, 264);
            this.pnProduct.Name = "pnProduct";
            this.pnProduct.Size = new System.Drawing.Size(220, 60);
            this.pnProduct.TabIndex = 4;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(-6, -12);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(237, 80);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "          Products";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(3, 330);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(220, 60);
            this.pnLogout.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-6, -12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(237, 80);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-6, -13);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(237, 80);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "          Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 605);
            this.Controls.Add(this.flpSidebar);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.flpSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            this.pnBilling.ResumeLayout(false);
            this.pnCustomer.ResumeLayout(false);
            this.pnProduct.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnBilling;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel pnProduct;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button btnMenu;
    }
}

