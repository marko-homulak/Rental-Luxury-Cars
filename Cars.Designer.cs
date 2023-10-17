namespace Rental_Luxury_Cars
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.user_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.user_picture = new System.Windows.Forms.PictureBox();
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.regNumber_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.regNumber_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.brand_label = new System.Windows.Forms.Label();
            this.brand_comboBox = new System.Windows.Forms.ComboBox();
            this.price_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.price_label = new System.Windows.Forms.Label();
            this.color_label = new System.Windows.Forms.Label();
            this.carStatus_label = new System.Windows.Forms.Label();
            this.carStatus_comboBox = new System.Windows.Forms.ComboBox();
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
            this.carsList_label = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.color_comboBox = new System.Windows.Forms.ComboBox();
            this.carsList_DataGrid = new System.Windows.Forms.DataGridView();
            this.model_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.return_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedCars_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsList_DataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            this.close_btn.TabIndex = 7;
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
            // regNumber_box
            // 
            this.regNumber_box.BackColor = System.Drawing.Color.White;
            this.regNumber_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regNumber_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regNumber_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regNumber_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.regNumber_box.HintForeColor = System.Drawing.Color.Purple;
            this.regNumber_box.HintText = "";
            this.regNumber_box.isPassword = false;
            this.regNumber_box.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.regNumber_box.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.regNumber_box.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.regNumber_box.LineThickness = 3;
            this.regNumber_box.Location = new System.Drawing.Point(62, 160);
            this.regNumber_box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.regNumber_box.Name = "regNumber_box";
            this.regNumber_box.Size = new System.Drawing.Size(160, 45);
            this.regNumber_box.TabIndex = 1;
            this.regNumber_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // regNumber_label
            // 
            this.regNumber_label.AutoSize = true;
            this.regNumber_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regNumber_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.regNumber_label.Location = new System.Drawing.Point(58, 133);
            this.regNumber_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.regNumber_label.Name = "regNumber_label";
            this.regNumber_label.Size = new System.Drawing.Size(133, 23);
            this.regNumber_label.TabIndex = 2;
            this.regNumber_label.Text = "Reg Number";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.model_label.Location = new System.Drawing.Point(640, 134);
            this.model_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(72, 23);
            this.model_label.TabIndex = 2;
            this.model_label.Text = "Model";
            // 
            // brand_label
            // 
            this.brand_label.AutoSize = true;
            this.brand_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brand_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.brand_label.Location = new System.Drawing.Point(342, 133);
            this.brand_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.brand_label.Name = "brand_label";
            this.brand_label.Size = new System.Drawing.Size(67, 23);
            this.brand_label.TabIndex = 2;
            this.brand_label.Text = "Brand";
            // 
            // brand_comboBox
            // 
            this.brand_comboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brand_comboBox.ForeColor = System.Drawing.Color.Purple;
            this.brand_comboBox.FormattingEnabled = true;
            this.brand_comboBox.Items.AddRange(new object[] {
            "Rolls Royce",
            "Aston Martin",
            "Bugatti",
            "Bentley",
            "Maserati",
            "Ferrari",
            "Porsche"});
            this.brand_comboBox.Location = new System.Drawing.Point(346, 160);
            this.brand_comboBox.Name = "brand_comboBox";
            this.brand_comboBox.Size = new System.Drawing.Size(180, 31);
            this.brand_comboBox.TabIndex = 3;
            this.brand_comboBox.SelectedIndexChanged += new System.EventHandler(this.brand_comboBox_SelectedIndexChanged);
            // 
            // price_box
            // 
            this.price_box.BackColor = System.Drawing.Color.White;
            this.price_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.price_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.price_box.HintForeColor = System.Drawing.Color.Purple;
            this.price_box.HintText = "";
            this.price_box.isPassword = false;
            this.price_box.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.price_box.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.price_box.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.price_box.LineThickness = 3;
            this.price_box.Location = new System.Drawing.Point(62, 246);
            this.price_box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(160, 45);
            this.price_box.TabIndex = 1;
            this.price_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.price_label.Location = new System.Drawing.Point(62, 219);
            this.price_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(118, 23);
            this.price_label.TabIndex = 2;
            this.price_label.Text = "Price / Day";
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.color_label.Location = new System.Drawing.Point(342, 220);
            this.color_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(63, 23);
            this.color_label.TabIndex = 2;
            this.color_label.Text = "Color";
            // 
            // carStatus_label
            // 
            this.carStatus_label.AutoSize = true;
            this.carStatus_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carStatus_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.carStatus_label.Location = new System.Drawing.Point(640, 220);
            this.carStatus_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.carStatus_label.Name = "carStatus_label";
            this.carStatus_label.Size = new System.Drawing.Size(110, 23);
            this.carStatus_label.TabIndex = 2;
            this.carStatus_label.Text = "Car Status";
            // 
            // carStatus_comboBox
            // 
            this.carStatus_comboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carStatus_comboBox.ForeColor = System.Drawing.Color.Purple;
            this.carStatus_comboBox.FormattingEnabled = true;
            this.carStatus_comboBox.Items.AddRange(new object[] {
            "AVAILABLE",
            "MAINTENANCE",
            "RENTED"});
            this.carStatus_comboBox.Location = new System.Drawing.Point(644, 246);
            this.carStatus_comboBox.Name = "carStatus_comboBox";
            this.carStatus_comboBox.Size = new System.Drawing.Size(262, 31);
            this.carStatus_comboBox.TabIndex = 3;
            this.carStatus_comboBox.SelectedIndexChanged += new System.EventHandler(this.carStatus_comboBox_SelectedIndexChanged);
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
            this.menu_panel.TabIndex = 4;
            // 
            // activing_panel
            // 
            this.activing_panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.activing_panel.Location = new System.Drawing.Point(58, 50);
            this.activing_panel.Name = "activing_panel";
            this.activing_panel.Size = new System.Drawing.Size(110, 5);
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
            this.customers_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customers_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customers_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.customers_label.Location = new System.Drawing.Point(332, 19);
            this.customers_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 18);
            this.customers_label.Name = "customers_label";
            this.customers_label.Size = new System.Drawing.Size(113, 23);
            this.customers_label.TabIndex = 2;
            this.customers_label.Text = "Customers";
            this.customers_label.Click += new System.EventHandler(this.customers_label_Click);
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
            this.cars_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cars_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cars_label.Location = new System.Drawing.Point(109, 19);
            this.cars_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 18);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(54, 23);
            this.cars_label.TabIndex = 2;
            this.cars_label.Text = "Cars";
            // 
            // carsList_label
            // 
            this.carsList_label.AutoSize = true;
            this.carsList_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsList_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.carsList_label.Location = new System.Drawing.Point(437, 353);
            this.carsList_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.carsList_label.Name = "carsList_label";
            this.carsList_label.Size = new System.Drawing.Size(89, 23);
            this.carsList_label.TabIndex = 2;
            this.carsList_label.Text = "Cars List";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(182, 305);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(148, 35);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(336, 305);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(148, 35);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(490, 305);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(148, 35);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(644, 305);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(148, 35);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // color_comboBox
            // 
            this.color_comboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_comboBox.ForeColor = System.Drawing.Color.Purple;
            this.color_comboBox.FormattingEnabled = true;
            this.color_comboBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Blue",
            "Green",
            "Purple",
            "Yellow",
            "Gold",
            "Silver"});
            this.color_comboBox.Location = new System.Drawing.Point(346, 246);
            this.color_comboBox.Name = "color_comboBox";
            this.color_comboBox.Size = new System.Drawing.Size(180, 31);
            this.color_comboBox.TabIndex = 3;
            // 
            // carsList_DataGrid
            // 
            this.carsList_DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.carsList_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsList_DataGrid.GridColor = System.Drawing.Color.Black;
            this.carsList_DataGrid.Location = new System.Drawing.Point(62, 379);
            this.carsList_DataGrid.Name = "carsList_DataGrid";
            this.carsList_DataGrid.RowHeadersWidth = 50;
            this.carsList_DataGrid.RowTemplate.Height = 24;
            this.carsList_DataGrid.Size = new System.Drawing.Size(844, 229);
            this.carsList_DataGrid.TabIndex = 7;
            this.carsList_DataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.carsList_DataGrid_CellMouseClick);
            // 
            // model_comboBox
            // 
            this.model_comboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_comboBox.ForeColor = System.Drawing.Color.Purple;
            this.model_comboBox.FormattingEnabled = true;
            this.model_comboBox.Items.AddRange(new object[] {
            "Rolls Royce",
            "Aston Martin",
            "Bugatti",
            "Bentley",
            "Maserati",
            "Ferrari",
            "Porsche"});
            this.model_comboBox.Location = new System.Drawing.Point(644, 160);
            this.model_comboBox.Name = "model_comboBox";
            this.model_comboBox.Size = new System.Drawing.Size(262, 31);
            this.model_comboBox.TabIndex = 3;
            this.model_comboBox.SelectedIndexChanged += new System.EventHandler(this.brand_comboBox_SelectedIndexChanged);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.carsList_DataGrid);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.color_comboBox);
            this.Controls.Add(this.carStatus_comboBox);
            this.Controls.Add(this.carStatus_label);
            this.Controls.Add(this.model_comboBox);
            this.Controls.Add(this.brand_comboBox);
            this.Controls.Add(this.brand_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.carsList_label);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.regNumber_label);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.regNumber_box);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.return_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedCars_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsList_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo_picture;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox user_picture;
        private System.Windows.Forms.Label user_label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox regNumber_box;
        private System.Windows.Forms.Label regNumber_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label brand_label;
        private System.Windows.Forms.ComboBox brand_comboBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox price_box;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Label carStatus_label;
        private System.Windows.Forms.ComboBox carStatus_comboBox;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.PictureBox cars_picture;
        private System.Windows.Forms.Label cars_label;
        private System.Windows.Forms.PictureBox return_picture;
        private System.Windows.Forms.PictureBox rentedCars_picture;
        private System.Windows.Forms.Label return_label;
        private System.Windows.Forms.PictureBox customers_picture;
        private System.Windows.Forms.Label rent_label;
        private System.Windows.Forms.Label customers_label;
        private System.Windows.Forms.Panel activing_panel;
        private System.Windows.Forms.Label carsList_label;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ComboBox color_comboBox;
        private System.Windows.Forms.DataGridView carsList_DataGrid;
        private System.Windows.Forms.ComboBox model_comboBox;
    }
}