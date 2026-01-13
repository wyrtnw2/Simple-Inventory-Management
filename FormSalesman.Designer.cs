namespace Simple_Inventory_Management
{
    partial class FormSalesman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesman));
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonCabinets = new System.Windows.Forms.Button();
            this.buttonCLose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonPositions = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.panelChildForm.Controls.Add(this.pictureBoxLogo);
            this.panelChildForm.Location = new System.Drawing.Point(198, 42);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(614, 413);
            this.panelChildForm.TabIndex = 42;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(108, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(403, 386);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonCabinets
            // 
            this.buttonCabinets.FlatAppearance.BorderSize = 0;
            this.buttonCabinets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCabinets.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCabinets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.buttonCabinets.Location = new System.Drawing.Point(0, 49);
            this.buttonCabinets.Name = "buttonCabinets";
            this.buttonCabinets.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCabinets.Size = new System.Drawing.Size(199, 36);
            this.buttonCabinets.TabIndex = 4;
            this.buttonCabinets.Text = "STOCKS";
            this.buttonCabinets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCabinets.UseVisualStyleBackColor = true;
            this.buttonCabinets.Click += new System.EventHandler(this.buttonCabinets_Click);
            // 
            // buttonCLose
            // 
            this.buttonCLose.BackColor = System.Drawing.Color.Transparent;
            this.buttonCLose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCLose.BackgroundImage")));
            this.buttonCLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCLose.FlatAppearance.BorderSize = 0;
            this.buttonCLose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCLose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCLose.Location = new System.Drawing.Point(776, 8);
            this.buttonCLose.Name = "buttonCLose";
            this.buttonCLose.Size = new System.Drawing.Size(23, 22);
            this.buttonCLose.TabIndex = 0;
            this.buttonCLose.UseVisualStyleBackColor = false;
            this.buttonCLose.Click += new System.EventHandler(this.buttonCLose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonUsers);
            this.panel2.Controls.Add(this.buttonCabinets);
            this.panel2.Controls.Add(this.buttonPositions);
            this.panel2.Location = new System.Drawing.Point(-1, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 413);
            this.panel2.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.button1.Location = new System.Drawing.Point(0, 133);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(199, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "PRICE HISTORY";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.buttonUsers.Location = new System.Drawing.Point(0, 91);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonUsers.Size = new System.Drawing.Size(199, 36);
            this.buttonUsers.TabIndex = 5;
            this.buttonUsers.Text = "PURCHASE ORDERS";
            this.buttonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonPositions
            // 
            this.buttonPositions.FlatAppearance.BorderSize = 0;
            this.buttonPositions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPositions.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPositions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.buttonPositions.Location = new System.Drawing.Point(0, 7);
            this.buttonPositions.Name = "buttonPositions";
            this.buttonPositions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPositions.Size = new System.Drawing.Size(199, 36);
            this.buttonPositions.TabIndex = 3;
            this.buttonPositions.Text = "SUPPLIERS";
            this.buttonPositions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPositions.UseVisualStyleBackColor = true;
            this.buttonPositions.Click += new System.EventHandler(this.buttonPositions_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Fuchsia;
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.buttonCLose);
            this.panelTop.Location = new System.Drawing.Point(-2, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop.Size = new System.Drawing.Size(814, 43);
            this.panelTop.TabIndex = 41;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // FormSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 455);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSalesman";
            this.Text = "FormSalesman";
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonCabinets;
        private System.Windows.Forms.Button buttonCLose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonPositions;
        private System.Windows.Forms.Panel panelTop;
    }
}