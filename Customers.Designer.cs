namespace Rental_Luxury_Cars
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.menu_panel = new System.Windows.Forms.Panel();
            this.activing_panel = new System.Windows.Forms.Panel();
            this.return_picture = new System.Windows.Forms.PictureBox();
            this.rentedCars_picture = new System.Windows.Forms.PictureBox();
            this.return_label = new System.Windows.Forms.Label();
            this.customers_picture = new System.Windows.Forms.PictureBox();
            this.rent_label = new System.Windows.Forms.Label();
            this.customers_label = new System.Windows.Forms.Label();
            this.cars_picture = new System.Windows.Forms.PictureBox();
            this.cars_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.customersList_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.customerName_label = new System.Windows.Forms.Label();
            this.phone_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customerName_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.user_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.user_picture = new System.Windows.Forms.PictureBox();
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.customersList_dataGrid = new System.Windows.Forms.DataGridView();
            this.city_comboBox = new System.Windows.Forms.ComboBox();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.return_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedCars_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars_picture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersList_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.White;
            this.menu_panel.Controls.Add(this.activing_panel);
            this.menu_panel.Controls.Add(this.return_picture);
            this.menu_panel.Controls.Add(this.rentedCars_picture);
            this.menu_panel.Controls.Add(this.return_label);
            this.menu_panel.Controls.Add(this.customers_picture);
            this.menu_panel.Controls.Add(this.rent_label);
            this.menu_panel.Controls.Add(this.customers_label);
            this.menu_panel.Controls.Add(this.cars_picture);
            this.menu_panel.Controls.Add(this.cars_label);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 60);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(960, 60);
            this.menu_panel.TabIndex = 20;
            // 
            // activing_panel
            // 
            this.activing_panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.activing_panel.Location = new System.Drawing.Point(285, 50);
            this.activing_panel.Name = "activing_panel";
            this.activing_panel.Size = new System.Drawing.Size(165, 5);
            this.activing_panel.TabIndex = 5;
            // 
            // return_picture
            // 
            this.return_picture.Image = ((System.Drawing.Image)(resources.GetObject("return_picture.Image")));
            this.return_picture.Location = new System.Drawing.Point(788, 5);
            this.return_picture.Margin = new System.Windows.Forms.Padding(2);
            this.return_picture.Name = "return_picture";
            this.return_picture.Size = new System.Drawing.Size(40, 40);
            this.return_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.return_picture.TabIndex = 0;
            this.return_picture.TabStop = false;
            // 
            // rentedCars_picture
            // 
            this.rentedCars_picture.Image = ((System.Drawing.Image)(resources.GetObject("rentedCars_picture.Image")));
            this.rentedCars_picture.Location = new System.Drawing.Point(554, 5);
            this.rentedCars_picture.Margin = new System.Windows.Forms.Padding(2);
            this.rentedCars_picture.Name = "rentedCars_picture";
            this.rentedCars_picture.Size = new System.Drawing.Size(40, 40);
            this.rentedCars_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rentedCars_picture.TabIndex = 0;
            this.rentedCars_picture.TabStop = false;
            // 
            // return_label
            // 
            this.return_label.AutoSize = true;
            this.return_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.return_label.Location = new System.Drawing.Point(835, 19);
            this.return_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 18);
            this.return_label.Name = "return_label";
            this.return_label.Size = new System.Drawing.Size(71, 23);
            this.return_label.TabIndex = 2;
            this.return_label.Text = "Return";
            this.return_label.Click += new System.EventHandler(this.return_label_Click);
            // 
            // customers_picture
            // 
            this.customers_picture.Image = ((System.Drawing.Image)(resources.GetObject("customers_picture.Image")));
            this.customers_picture.Location = new System.Drawing.Point(285, 5);
            this.customers_picture.Margin = new System.Windows.Forms.Padding(2);
            this.customers_picture.Name = "customers_picture";
            this.customers_picture.Size = new System.Drawing.Size(40, 40);
            this.customers_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customers_picture.TabIndex = 0;
            this.customers_picture.TabStop = false;
            // 
            // rent_label
            // 
            this.rent_label.AutoSize = true;
            this.rent_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rent_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rent_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.rent_label.Location = new System.Drawing.Point(601, 19);
            this.rent_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 18);
            this.rent_label.Name = "rent_label";
            this.rent_label.Size = new System.Drawing.Size(53, 23);
            this.rent_label.TabIndex = 2;
            this.rent_label.Text = "Rent";
            this.rent_label.Click += new System.EventHandler(this.rent_label_Click);
            // 
            // customers_label
            // 
            this.customers_label.AutoSize = true;
            this.customers_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customers_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.customers_label.Location = new System.Drawing.Point(332, 19);
            this.customers_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 18);
            this.customers_label.Name = "customers_label";
            this.customers_label.Size = new System.Drawing.Size(113, 23);
            this.customers_label.TabIndex = 2;
            this.customers_label.Text = "Customers";
            // 
            // cars_picture
            // 
            this.cars_picture.Image = ((System.Drawing.Image)(resources.GetObject("cars_picture.Image")));
            this.cars_picture.Location = new System.Drawing.Point(62, 5);
            this.cars_picture.Margin = new System.Windows.Forms.Padding(2);
            this.cars_picture.Name = "cars_picture";
            this.cars_picture.Size = new System.Drawing.Size(40, 40);
            this.cars_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cars_picture.TabIndex = 0;
            this.cars_picture.TabStop = false;
            // 
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cars_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cars_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cars_label.Location = new System.Drawing.Point(109, 19);
            this.cars_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 18);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(54, 23);
            this.cars_label.TabIndex = 2;
            this.cars_label.Text = "Cars";
            this.cars_label.Click += new System.EventHandler(this.cars_label_Click);
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.phone_label.Location = new System.Drawing.Point(702, 133);
            this.phone_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(72, 23);
            this.phone_label.TabIndex = 13;
            this.phone_label.Text = "Phone";
            // 
            // customersList_label
            // 
            this.customersList_label.AutoSize = true;
            this.customersList_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersList_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.customersList_label.Location = new System.Drawing.Point(420, 267);
            this.customersList_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.customersList_label.Name = "customersList_label";
            this.customersList_label.Size = new System.Drawing.Size(148, 23);
            this.customersList_label.TabIndex = 14;
            this.customersList_label.Text = "Customers List";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.city_label.Location = new System.Drawing.Point(402, 133);
            this.city_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(88, 23);
            this.city_label.TabIndex = 16;
            this.city_label.Text = "Address";
            // 
            // customerName_label
            // 
            this.customerName_label.AutoSize = true;
            this.customerName_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.customerName_label.Location = new System.Drawing.Point(58, 133);
            this.customerName_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.customerName_label.Name = "customerName_label";
            this.customerName_label.Size = new System.Drawing.Size(209, 23);
            this.customerName_label.TabIndex = 17;
            this.customerName_label.Text = "Customer Full Name";
            // 
            // phone_box
            // 
            this.phone_box.BackColor = System.Drawing.Color.White;
            this.phone_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.phone_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.phone_box.HintForeColor = System.Drawing.Color.Purple;
            this.phone_box.HintText = "";
            this.phone_box.isPassword = false;
            this.phone_box.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.phone_box.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.phone_box.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.phone_box.LineThickness = 3;
            this.phone_box.Location = new System.Drawing.Point(706, 160);
            this.phone_box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(200, 45);
            this.phone_box.TabIndex = 7;
            this.phone_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // customerName_box
            // 
            this.customerName_box.BackColor = System.Drawing.Color.White;
            this.customerName_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customerName_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerName_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerName_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.customerName_box.HintForeColor = System.Drawing.Color.Purple;
            this.customerName_box.HintText = "";
            this.customerName_box.isPassword = false;
            this.customerName_box.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.customerName_box.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.customerName_box.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.customerName_box.LineThickness = 3;
            this.customerName_box.Location = new System.Drawing.Point(62, 160);
            this.customerName_box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.customerName_box.Name = "customerName_box";
            this.customerName_box.Size = new System.Drawing.Size(240, 45);
            this.customerName_box.TabIndex = 10;
            this.customerName_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.user_label);
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Controls.Add(this.user_picture);
            this.panel1.Controls.Add(this.logo_picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 60);
            this.panel1.TabIndex = 6;
            // 
            // close_btn
            // 
            this.close_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_btn.BackgroundImage")));
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(930, 0);
            this.close_btn.Margin = new System.Windows.Forms.Padding(0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(30, 30);
            this.close_btn.TabIndex = 26;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.user_label.Location = new System.Drawing.Point(784, 19);
            this.user_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 18);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(111, 23);
            this.user_label.TabIndex = 2;
            this.user_label.Text = "UserName";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.title_label.Location = new System.Drawing.Point(58, 19);
            this.title_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 18);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(395, 23);
            this.title_label.TabIndex = 2;
            this.title_label.Text = "Luxury Car Rental Management System";
            // 
            // user_picture
            // 
            this.user_picture.Image = ((System.Drawing.Image)(resources.GetObject("user_picture.Image")));
            this.user_picture.Location = new System.Drawing.Point(737, 11);
            this.user_picture.Margin = new System.Windows.Forms.Padding(2);
            this.user_picture.Name = "user_picture";
            this.user_picture.Size = new System.Drawing.Size(40, 40);
            this.user_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_picture.TabIndex = 1;
            this.user_picture.TabStop = false;
            // 
            // logo_picture
            // 
            this.logo_picture.Image = ((System.Drawing.Image)(resources.GetObject("logo_picture.Image")));
            this.logo_picture.Location = new System.Drawing.Point(11, 11);
            this.logo_picture.Margin = new System.Windows.Forms.Padding(2);
            this.logo_picture.Name = "logo_picture";
            this.logo_picture.Size = new System.Drawing.Size(40, 40);
            this.logo_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_picture.TabIndex = 1;
            this.logo_picture.TabStop = false;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(645, 219);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(148, 35);
            this.clear_btn.TabIndex = 22;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(491, 219);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(148, 35);
            this.delete_btn.TabIndex = 23;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(337, 219);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(148, 35);
            this.edit_btn.TabIndex = 24;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(183, 219);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(148, 35);
            this.add_btn.TabIndex = 25;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // customersList_dataGrid
            // 
            this.customersList_dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customersList_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersList_dataGrid.GridColor = System.Drawing.Color.Black;
            this.customersList_dataGrid.Location = new System.Drawing.Point(62, 293);
            this.customersList_dataGrid.Name = "customersList_dataGrid";
            this.customersList_dataGrid.RowHeadersWidth = 51;
            this.customersList_dataGrid.RowTemplate.Height = 24;
            this.customersList_dataGrid.Size = new System.Drawing.Size(844, 315);
            this.customersList_dataGrid.TabIndex = 26;
            this.customersList_dataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customersList_dataGrid_CellMouseClick);
            // 
            // city_comboBox
            // 
            this.city_comboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_comboBox.ForeColor = System.Drawing.Color.Purple;
            this.city_comboBox.FormattingEnabled = true;
            this.city_comboBox.Items.AddRange(new object[] {
            "Lviv",
            "Kyiv",
            "Odessa",
            "Vinnytsia",
            "Uzhhorod",
            "Kharkiv"});
            this.city_comboBox.Location = new System.Drawing.Point(406, 160);
            this.city_comboBox.Name = "city_comboBox";
            this.city_comboBox.Size = new System.Drawing.Size(180, 31);
            this.city_comboBox.TabIndex = 27;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.city_comboBox);
            this.Controls.Add(this.customersList_dataGrid);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.customersList_label);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.customerName_label);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.customerName_box);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.return_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedCars_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersList_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel activing_panel;
        private System.Windows.Forms.PictureBox return_picture;
        private System.Windows.Forms.PictureBox rentedCars_picture;
        private System.Windows.Forms.Label return_label;
        private System.Windows.Forms.PictureBox customers_picture;
        private System.Windows.Forms.Label rent_label;
        private System.Windows.Forms.Label customers_label;
        private System.Windows.Forms.PictureBox cars_picture;
        private System.Windows.Forms.Label cars_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label customersList_label;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.Label customerName_label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phone_box;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customerName_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox user_picture;
        private System.Windows.Forms.PictureBox logo_picture;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DataGridView customersList_dataGrid;
        private System.Windows.Forms.ComboBox city_comboBox;
    }
}