
namespace WarsztatAplikacja
{
    partial class PanelPracownik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPracownik));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Naprawy = new System.Windows.Forms.ToolStripMenuItem();
            this.samochodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.częściToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dostawcyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widoktabel = new System.Windows.Forms.DataGridView();
            this.wybierztabele = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widoktabel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Naprawy,
            this.samochodyToolStripMenuItem,
            this.częściToolStripMenuItem,
            this.dostawcyToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Naprawy
            // 
            this.Naprawy.Name = "Naprawy";
            this.Naprawy.Size = new System.Drawing.Size(112, 21);
            this.Naprawy.Text = "Naprawy-Raporty";
            this.Naprawy.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // samochodyToolStripMenuItem
            // 
            this.samochodyToolStripMenuItem.Name = "samochodyToolStripMenuItem";
            this.samochodyToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.samochodyToolStripMenuItem.Text = "Samochody";
            this.samochodyToolStripMenuItem.Click += new System.EventHandler(this.samochodyToolStripMenuItem_Click);
            // 
            // częściToolStripMenuItem
            // 
            this.częściToolStripMenuItem.Name = "częściToolStripMenuItem";
            this.częściToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.częściToolStripMenuItem.Text = "Części";
            this.częściToolStripMenuItem.Click += new System.EventHandler(this.częściToolStripMenuItem_Click);
            // 
            // dostawcyToolStripMenuItem
            // 
            this.dostawcyToolStripMenuItem.Name = "dostawcyToolStripMenuItem";
            this.dostawcyToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.dostawcyToolStripMenuItem.Text = "Dostawcy";
            this.dostawcyToolStripMenuItem.Click += new System.EventHandler(this.dostawcyToolStripMenuItem_Click);
            // 
            // widoktabel
            // 
            this.widoktabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widoktabel.Location = new System.Drawing.Point(12, 185);
            this.widoktabel.Name = "widoktabel";
            this.widoktabel.Size = new System.Drawing.Size(507, 253);
            this.widoktabel.TabIndex = 1;
            this.widoktabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.widoktabel_CellContentClick);
            // 
            // wybierztabele
            // 
            this.wybierztabele.FormattingEnabled = true;
            this.wybierztabele.Items.AddRange(new object[] {
            "Naprawy",
            "Samochody",
            "Części",
            "Dostawcy"});
            this.wybierztabele.Location = new System.Drawing.Point(169, 142);
            this.wybierztabele.Name = "wybierztabele";
            this.wybierztabele.Size = new System.Drawing.Size(148, 21);
            this.wybierztabele.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz widok:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(323, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zmień";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // PanelPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wybierztabele);
            this.Controls.Add(this.widoktabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PanelPracownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelPracownik";
            this.Load += new System.EventHandler(this.PanelPracownik_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widoktabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Naprawy;
        private System.Windows.Forms.ToolStripMenuItem samochodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem częściToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dostawcyToolStripMenuItem;
        private System.Windows.Forms.DataGridView widoktabel;
        private System.Windows.Forms.ComboBox wybierztabele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
    }
}