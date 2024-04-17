namespace GROUP_3_DESIGNING_FORM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.faclbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.logbut = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.signbut = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnhide = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).BeginInit();
            this.SuspendLayout();
            // 
            // faclbl
            // 
            this.faclbl.AutoSize = true;
            this.faclbl.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faclbl.Location = new System.Drawing.Point(58, 28);
            this.faclbl.Name = "faclbl";
            this.faclbl.Size = new System.Drawing.Size(178, 18);
            this.faclbl.TabIndex = 0;
            this.faclbl.Text = "FACULTY PERSONEL LOGIN";
            this.faclbl.Click += new System.EventHandler(this.faclbl_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(12, 102);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(41, 18);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Name";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(12, 133);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(59, 18);
            this.passlbl.TabIndex = 2;
            this.passlbl.Text = "Password";
            // 
            // logbut
            // 
            this.logbut.BackColor = System.Drawing.Color.SeaGreen;
            this.logbut.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbut.Location = new System.Drawing.Point(78, 178);
            this.logbut.Name = "logbut";
            this.logbut.Size = new System.Drawing.Size(158, 28);
            this.logbut.TabIndex = 3;
            this.logbut.Text = "LOG IN";
            this.logbut.UseVisualStyleBackColor = false;
            this.logbut.Click += new System.EventHandler(this.logbut_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtname.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(85, 95);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(153, 25);
            this.txtname.TabIndex = 4;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            this.txtname.Validating += new System.ComponentModel.CancelEventHandler(this.txtname_Validating);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtpass.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(85, 126);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(153, 25);
            this.txtpass.TabIndex = 5;
            this.txtpass.Validating += new System.ComponentModel.CancelEventHandler(this.txtpass_Validating);
            // 
            // signbut
            // 
            this.signbut.BackColor = System.Drawing.Color.SeaGreen;
            this.signbut.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signbut.Location = new System.Drawing.Point(80, 212);
            this.signbut.Name = "signbut";
            this.signbut.Size = new System.Drawing.Size(158, 28);
            this.signbut.TabIndex = 6;
            this.signbut.Text = "SIGN IN";
            this.signbut.UseVisualStyleBackColor = false;
            this.signbut.Click += new System.EventHandler(this.signbut_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackgroundImage = global::GROUP_3_DESIGNING_FORM.Properties.Resources.swipe_left;
            this.btnshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshow.Location = new System.Drawing.Point(234, 126);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(41, 25);
            this.btnshow.TabIndex = 16;
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnhide
            // 
            this.btnhide.BackgroundImage = global::GROUP_3_DESIGNING_FORM.Properties.Resources.swipe_right;
            this.btnhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhide.Location = new System.Drawing.Point(234, 126);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(41, 25);
            this.btnhide.TabIndex = 17;
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderPass
            // 
            this.errorProviderPass.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(290, 290);
            this.Controls.Add(this.signbut);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.logbut);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.faclbl);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.btnshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FACULTY PERSONEL LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label faclbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Button logbut;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button signbut;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnhide;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderPass;
    }
}

