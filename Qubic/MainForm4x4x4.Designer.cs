
namespace Qubic
{
    partial class MainForm4x4x4
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
            this.newMenu = new System.Windows.Forms.MenuStrip();
            this.novaIgraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.predajaXIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predajaOIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.xStatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.oStatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.xNameLabel = new System.Windows.Forms.Label();
            this.oNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LabelMove = new System.Windows.Forms.Label();
            this.hintButton = new System.Windows.Forms.Button();
            this.nbMoveLabel = new System.Windows.Forms.Label();
            this.tableControl =(table) new Qubic.table4Control();
            this.newMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // newMenu
            // 
            this.newMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.newMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIgraToolStripMenuItem,
            this.closeMenu,
            this.resultsMenu,
            this.statMenu,
            this.rulesMenu});
            this.newMenu.Location = new System.Drawing.Point(0, 0);
            this.newMenu.Name = "newMenu";
            this.newMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.newMenu.Size = new System.Drawing.Size(608, 24);
            this.newMenu.TabIndex = 0;
            this.newMenu.Text = "menuStrip1";
            // 
            // novaIgraToolStripMenuItem
            // 
            this.novaIgraToolStripMenuItem.Name = "novaIgraToolStripMenuItem";
            this.novaIgraToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.novaIgraToolStripMenuItem.Text = "Nova igra";
            this.novaIgraToolStripMenuItem.Click += new System.EventHandler(this.novaIgraToolStripMenuItem_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predajaXIgračaToolStripMenuItem,
            this.predajaOIgračaToolStripMenuItem});
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(74, 20);
            this.closeMenu.Text = "Završi igru";
            // 
            // predajaXIgračaToolStripMenuItem
            // 
            this.predajaXIgračaToolStripMenuItem.Name = "predajaXIgračaToolStripMenuItem";
            this.predajaXIgračaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.predajaXIgračaToolStripMenuItem.Text = "Predaja X igrača";
            this.predajaXIgračaToolStripMenuItem.Click += new System.EventHandler(this.predajaXIgračaToolStripMenuItem_Click);
            // 
            // predajaOIgračaToolStripMenuItem
            // 
            this.predajaOIgračaToolStripMenuItem.Name = "predajaOIgračaToolStripMenuItem";
            this.predajaOIgračaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.predajaOIgračaToolStripMenuItem.Text = "Predaja O igrača";
            this.predajaOIgračaToolStripMenuItem.Click += new System.EventHandler(this.predajaOIgračaToolStripMenuItem_Click);
            // 
            // resultsMenu
            // 
            this.resultsMenu.Name = "resultsMenu";
            this.resultsMenu.Size = new System.Drawing.Size(105, 20);
            this.resultsMenu.Text = "Najbolji rezultati";
            this.resultsMenu.Click += new System.EventHandler(this.resultsMenu_Click);
            this.resultsMenu.DoubleClick += new System.EventHandler(this.resultsMenu_Click);
            // 
            // statMenu
            // 
            this.statMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xStatMenu,
            this.oStatMenu});
            this.statMenu.Name = "statMenu";
            this.statMenu.Size = new System.Drawing.Size(66, 20);
            this.statMenu.Text = "Statistika";
            // 
            // xStatMenu
            // 
            this.xStatMenu.Name = "xStatMenu";
            this.xStatMenu.Size = new System.Drawing.Size(168, 22);
            this.xStatMenu.Text = "Statistika X igrača";
            this.xStatMenu.Click += new System.EventHandler(this.xStatMenu_Click);
            // 
            // oStatMenu
            // 
            this.oStatMenu.Name = "oStatMenu";
            this.oStatMenu.Size = new System.Drawing.Size(168, 22);
            this.oStatMenu.Text = "Statistika O igrača";
            this.oStatMenu.Click += new System.EventHandler(this.oStatMenu_Click);
            // 
            // rulesMenu
            // 
            this.rulesMenu.Name = "rulesMenu";
            this.rulesMenu.Size = new System.Drawing.Size(54, 20);
            this.rulesMenu.Text = "Pravila";
            this.rulesMenu.Click += new System.EventHandler(this.rulesMenuClicked);
            this.rulesMenu.DoubleClick += new System.EventHandler(this.rulesMenuClicked);
            // 
            // xNameLabel
            // 
            this.xNameLabel.AutoSize = true;
            this.xNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.xNameLabel.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xNameLabel.ForeColor = System.Drawing.Color.RosyBrown;
            this.xNameLabel.Location = new System.Drawing.Point(361, 130);
            this.xNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xNameLabel.Name = "xNameLabel";
            this.xNameLabel.Size = new System.Drawing.Size(94, 32);
            this.xNameLabel.TabIndex = 1;
            this.xNameLabel.Text = "X: ime";
            // 
            // oNameLabel
            // 
            this.oNameLabel.AutoSize = true;
            this.oNameLabel.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oNameLabel.Location = new System.Drawing.Point(361, 239);
            this.oNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oNameLabel.Name = "oNameLabel";
            this.oNameLabel.Size = new System.Drawing.Size(95, 32);
            this.oNameLabel.TabIndex = 2;
            this.oNameLabel.Text = "O: ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "vs";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // LabelMove
            // 
            this.LabelMove.AutoSize = true;
            this.LabelMove.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMove.Location = new System.Drawing.Point(362, 370);
            this.LabelMove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMove.Name = "LabelMove";
            this.LabelMove.Size = new System.Drawing.Size(109, 28);
            this.LabelMove.TabIndex = 4;
            this.LabelMove.Text = "Broj poteza:";
            // 
            // hintButton
            // 
            this.hintButton.BackColor = System.Drawing.Color.RosyBrown;
            this.hintButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintButton.Location = new System.Drawing.Point(366, 496);
            this.hintButton.Margin = new System.Windows.Forms.Padding(2);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(114, 45);
            this.hintButton.TabIndex = 5;
            this.hintButton.Text = "Hint";
            this.hintButton.UseVisualStyleBackColor = false;
            this.hintButton.Click += new System.EventHandler(this.hintButton_Click);
            // 
            // nbMoveLabel
            // 
            this.nbMoveLabel.AutoSize = true;
            this.nbMoveLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbMoveLabel.ForeColor = System.Drawing.Color.Black;
            this.nbMoveLabel.Location = new System.Drawing.Point(470, 370);
            this.nbMoveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nbMoveLabel.Name = "nbMoveLabel";
            this.nbMoveLabel.Size = new System.Drawing.Size(23, 28);
            this.nbMoveLabel.TabIndex = 6;
            this.nbMoveLabel.Text = "0";
            // 
            // tableControl
            // 
            //Ako designer ne radi treba maknut komentar s 50.te linije
            //ali onda igra 3x3x3 ne radi
            this.tableControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableControl.Location = new System.Drawing.Point(0, 24);
            this.tableControl.Margin = new System.Windows.Forms.Padding(2);
            this.tableControl.Name = "tableControl";
            this.tableControl.Size = new System.Drawing.Size(319, 737);
            this.tableControl.TabIndex = 7;
            // 
            // MainForm4x4x4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(608, 761);
            this.Controls.Add(this.tableControl);
            this.Controls.Add(this.nbMoveLabel);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.LabelMove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oNameLabel);
            this.Controls.Add(this.xNameLabel);
            this.Controls.Add(this.newMenu);
            this.MainMenuStrip = this.newMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm4x4x4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Qubic - 4x4x4 varijanta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm4x4x4_FormClosing);
            this.newMenu.ResumeLayout(false);
            this.newMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip newMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ToolStripMenuItem predajaXIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predajaOIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsMenu;
        private System.Windows.Forms.Label xNameLabel;
        private System.Windows.Forms.Label oNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label LabelMove;
        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.Label nbMoveLabel;
        private System.Windows.Forms.ToolStripMenuItem rulesMenu;
        private System.Windows.Forms.ToolStripMenuItem novaIgraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statMenu;
        private System.Windows.Forms.ToolStripMenuItem xStatMenu;
        private System.Windows.Forms.ToolStripMenuItem oStatMenu;
        private table tableControl;
    }
}