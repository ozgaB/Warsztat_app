
namespace WarsztatAplikacja
{
    partial class ZalogujPracownik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZalogujPracownik));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_input = new System.Windows.Forms.TextBox();
            this.haslo_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.powrot_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(154, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(154, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło:";
            // 
            // login_input
            // 
            this.login_input.Location = new System.Drawing.Point(138, 248);
            this.login_input.Name = "login_input";
            this.login_input.Size = new System.Drawing.Size(100, 20);
            this.login_input.TabIndex = 3;
            this.login_input.Text = "pracownik1234";
            // 
            // haslo_input
            // 
            this.haslo_input.Location = new System.Drawing.Point(138, 319);
            this.haslo_input.Name = "haslo_input";
            this.haslo_input.Size = new System.Drawing.Size(100, 20);
            this.haslo_input.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(138, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zaloguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // help_btn
            // 
            this.help_btn.BackgroundImage = global::WarsztatAplikacja.Properties.Resources.Help_icon_icons_com_55891;
            this.help_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.help_btn.Location = new System.Drawing.Point(322, 397);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(40, 40);
            this.help_btn.TabIndex = 7;
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // powrot_btn
            // 
            this.powrot_btn.BackgroundImage = global::WarsztatAplikacja.Properties.Resources.back_arrow_icon_icons_com_72866__1_;
            this.powrot_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.powrot_btn.Location = new System.Drawing.Point(12, 397);
            this.powrot_btn.Name = "powrot_btn";
            this.powrot_btn.Size = new System.Drawing.Size(40, 38);
            this.powrot_btn.TabIndex = 6;
            this.powrot_btn.UseVisualStyleBackColor = true;
            this.powrot_btn.Click += new System.EventHandler(this.powrot_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarsztatAplikacja.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ZalogujPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 449);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.powrot_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.haslo_input);
            this.Controls.Add(this.login_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZalogujPracownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_input;
        private System.Windows.Forms.TextBox haslo_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button powrot_btn;
        private System.Windows.Forms.Button help_btn;
    }
}