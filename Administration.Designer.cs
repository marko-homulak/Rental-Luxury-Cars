namespace Rental_Luxury_Cars
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.usersList_DataGrid = new System.Windows.Forms.DataGridView();
            this.users_picture = new System.Windows.Forms.PictureBox();
            this.customers_label = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.activing_panel = new System.Windows.Forms.Panel();
            this.usersList_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.userName_label = new System.Windows.Forms.Label();
            this.password_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userName_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.close_btn = new System.Windows.Forms.Button();
            this.user_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.user_picture = new System.Windows.Forms.PictureBox();
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.usersList_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_picture)).BeginInit();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersList_DataGrid
            // 
            this.usersList_DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.usersList_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersList_DataGrid.GridColor = System.Drawing.Color.Black;
            this.usersList_DataGrid.Location = new System.Drawing.Point(182, 299);
            this.usersList_DataGrid.Name = "usersList_DataGrid";
            this.usersList_DataGrid.RowHeadersWidth = 50;
            this.usersList_DataGrid.RowTemplate.Height = 24;
            this.usersList_DataGrid.Size = new System.Drawing.Size(610, 315);
            this.usersList_DataGrid.TabIndex = 27;
            this.usersList_DataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usersList_DataGrid_CellMouseClick);
            // 
            // users_picture
            // 
            this.users_picture.Image = ((System.Drawing.Image)(resources.GetObject("users_picture.Image")));
            this.users_picture.Location = new System.Drawing.Point(424, 5);
            this.users_picture.Margin = new System.Windows.Forms.Padding(2);
            this.users_picture.Name = "users_picture";
            this.users_picture.Size = new System.Drawing.Size(40, 40);
            this.users_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.users_picture.TabIndex = 0;
            this.users_picture.TabStop = false;
            // 
            // customers_label
            // 
            this.customers_label.AutoSize = true;
            this.customers_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customers_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.customers_label.Location = new System.Drawing.Point(471, 22);
            this.customers_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 18);
            this.customers_label.Name = "customers_label";
            this.customers_label.Size = new System.Drawing.Size(107, 23);
            this.customers_label.TabIndex = 2;
            this.customers_label.Text = "Add Users";
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(644, 225);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(148, 35);
            this.clear_btn.TabIndex = 26;
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
            this.delete_btn.Location = new System.Drawing.Point(490, 225);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(148, 35);
            this.delete_btn.TabIndex = 25;
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
            this.edit_btn.Location = new System.Drawing.Point(336, 225);
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
            this.add_btn.Location = new System.Drawing.Point(182, 225);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(148, 35);
            this.add_btn.TabIndex = 23;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.White;
            this.menu_panel.Controls.Add(this.activing_panel);
            this.menu_panel.Controls.Add(this.users_picture);
            this.menu_panel.Controls.Add(this.customers_label);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 60);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(960, 60);
            this.menu_panel.TabIndex = 22;
            // 
            // activing_panel
            // 
            this.activing_panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.activing_panel.Location = new System.Drawing.Point(424, 50);
            this.activing_panel.Name = "activing_panel";
            this.activing_panel.Size = new System.Drawing.Size(160, 5);
            this.activing_panel.TabIndex = 5;
            // 
            // usersList_label
            // 
            this.usersList_label.AutoSize = true;
            this.usersList_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersList_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.usersList_label.Location = new System.Drawing.Point(435, 273);
            this.usersList_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.usersList_label.Name = "usersList_label";
            this.usersList_label.Size = new System.Drawing.Size(95, 23);
            this.usersList_label.TabIndex = 15;
            this.usersList_label.Text = "Users List";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.password_label.Location = new System.Drawing.Point(490, 133);
            this.password_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(103, 23);
            this.password_label.TabIndex = 13;
            this.password_label.Text = "Password";
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userName_label.Location = new System.Drawing.Point(178, 139);
            this.userName_label.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(117, 23);
            this.userName_label.TabIndex = 12;
            this.userName_label.Text = "User Name";
            // 
            // password_box
            // 
            this.password_box.BackColor = System.Drawing.Color.White;
            this.password_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.password_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.password_box.HintForeColor = System.Drawing.Color.Purple;
            this.password_box.HintText = "";
            this.password_box.isPassword = false;
            this.password_box.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.password_box.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.password_box.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.password_box.LineThickness = 3;
            this.password_box.Location = new System.Drawing.Point(494, 166);
            this.password_box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(298, 45);
            this.password_box.TabIndex = 9;
            this.password_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // userName_box
            // 
            this.userName_box.BackColor = System.Drawing.Color.White;
            this.userName_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userName_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.userName_box.HintForeColor = System.Drawing.Color.Purple;
            this.userName_box.HintText = "";
            this.userName_box.isPassword = false;
            this.userName_box.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.userName_box.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userName_box.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userName_box.LineThickness = 3;
            this.userName_box.Location = new System.Drawing.Point(182, 166);
            this.userName_box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userName_box.Name = "userName_box";
            this.userName_box.Size = new System.Drawing.Size(302, 45);
            this.userName_box.TabIndex = 10;
            this.userName_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.panel1.TabIndex = 8;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.usersList_DataGrid);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.usersList_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.userName_box);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersList_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_picture)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersList_DataGrid;
        private System.Windows.Forms.PictureBox users_picture;
        private System.Windows.Forms.Label customers_label;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel activing_panel;
        private System.Windows.Forms.Label usersList_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label userName_label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_box;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userName_box;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox user_picture;
        private System.Windows.Forms.PictureBox logo_picture;
        private System.Windows.Forms.Panel panel1;
    }
}