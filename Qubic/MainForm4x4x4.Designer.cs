﻿
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
            this.rulesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.xNameLabel = new System.Windows.Forms.Label();
            this.oNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LabelMove = new System.Windows.Forms.Label();
            this.hintButton = new System.Windows.Forms.Button();
            this.nbMoveLabel = new System.Windows.Forms.Label();
            this.level4Form1 = new Qubic.level4Form();
            this.level4Form2 = new Qubic.level4Form();
            this.level4Form3 = new Qubic.level4Form();
            this.level4Form4 = new Qubic.level4Form();
            this.statMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.xStatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.oStatMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.newMenu.Size = new System.Drawing.Size(942, 28);
            this.newMenu.TabIndex = 0;
            this.newMenu.Text = "menuStrip1";
            // 
            // novaIgraToolStripMenuItem
            // 
            this.novaIgraToolStripMenuItem.Name = "novaIgraToolStripMenuItem";
            this.novaIgraToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.novaIgraToolStripMenuItem.Text = "Nova igra";
            // 
            // closeMenu
            // 
            this.closeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predajaXIgračaToolStripMenuItem,
            this.predajaOIgračaToolStripMenuItem});
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(92, 24);
            this.closeMenu.Text = "Završi igru";
            // 
            // predajaXIgračaToolStripMenuItem
            // 
            this.predajaXIgračaToolStripMenuItem.Name = "predajaXIgračaToolStripMenuItem";
            this.predajaXIgračaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.predajaXIgračaToolStripMenuItem.Text = "Predaja X igrača";
            // 
            // predajaOIgračaToolStripMenuItem
            // 
            this.predajaOIgračaToolStripMenuItem.Name = "predajaOIgračaToolStripMenuItem";
            this.predajaOIgračaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.predajaOIgračaToolStripMenuItem.Text = "Predaja O igrača";
            // 
            // resultsMenu
            // 
            this.resultsMenu.Name = "resultsMenu";
            this.resultsMenu.Size = new System.Drawing.Size(134, 24);
            this.resultsMenu.Text = "Najbolji rezultati";
            this.resultsMenu.Click += new System.EventHandler(this.resultsMenu_Click);
            this.resultsMenu.DoubleClick += new System.EventHandler(this.resultsMenu_Click);
            // 
            // rulesMenu
            // 
            this.rulesMenu.Name = "rulesMenu";
            this.rulesMenu.Size = new System.Drawing.Size(67, 24);
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
            this.xNameLabel.Location = new System.Drawing.Point(481, 160);
            this.xNameLabel.Name = "xNameLabel";
            this.xNameLabel.Size = new System.Drawing.Size(114, 39);
            this.xNameLabel.TabIndex = 1;
            this.xNameLabel.Text = "X: ime";
            // 
            // oNameLabel
            // 
            this.oNameLabel.AutoSize = true;
            this.oNameLabel.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oNameLabel.Location = new System.Drawing.Point(481, 294);
            this.oNameLabel.Name = "oNameLabel";
            this.oNameLabel.Size = new System.Drawing.Size(115, 39);
            this.oNameLabel.TabIndex = 2;
            this.oNameLabel.Text = "O: ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 30);
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
            this.LabelMove.Location = new System.Drawing.Point(482, 846);
            this.LabelMove.Name = "LabelMove";
            this.LabelMove.Size = new System.Drawing.Size(138, 36);
            this.LabelMove.TabIndex = 4;
            this.LabelMove.Text = "Broj poteza:";
            // 
            // hintButton
            // 
            this.hintButton.BackColor = System.Drawing.Color.RosyBrown;
            this.hintButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintButton.Location = new System.Drawing.Point(488, 547);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(152, 55);
            this.hintButton.TabIndex = 5;
            this.hintButton.Text = "Hint";
            this.hintButton.UseVisualStyleBackColor = false;
            // 
            // nbMoveLabel
            // 
            this.nbMoveLabel.AutoSize = true;
            this.nbMoveLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbMoveLabel.ForeColor = System.Drawing.Color.Black;
            this.nbMoveLabel.Location = new System.Drawing.Point(626, 846);
            this.nbMoveLabel.Name = "nbMoveLabel";
            this.nbMoveLabel.Size = new System.Drawing.Size(29, 36);
            this.nbMoveLabel.TabIndex = 6;
            this.nbMoveLabel.Text = "0";
            // 
            // level4Form1
            // 
            this.level4Form1.Location = new System.Drawing.Point(165, 43);
            this.level4Form1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level4Form1.Name = "level4Form1";
            this.level4Form1.Size = new System.Drawing.Size(208, 212);
            this.level4Form1.TabIndex = 7;
            // 
            // level4Form2
            // 
            this.level4Form2.Location = new System.Drawing.Point(112, 261);
            this.level4Form2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level4Form2.Name = "level4Form2";
            this.level4Form2.Size = new System.Drawing.Size(203, 207);
            this.level4Form2.TabIndex = 8;
            // 
            // level4Form3
            // 
            this.level4Form3.Location = new System.Drawing.Point(63, 474);
            this.level4Form3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level4Form3.Name = "level4Form3";
            this.level4Form3.Size = new System.Drawing.Size(203, 207);
            this.level4Form3.TabIndex = 9;
            // 
            // level4Form4
            // 
            this.level4Form4.Location = new System.Drawing.Point(12, 687);
            this.level4Form4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level4Form4.Name = "level4Form4";
            this.level4Form4.Size = new System.Drawing.Size(204, 209);
            this.level4Form4.TabIndex = 10;
            // 
            // statMenu
            // 
            this.statMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xStatMenu,
            this.oStatMenu});
            this.statMenu.Name = "statMenu";
            this.statMenu.Size = new System.Drawing.Size(83, 24);
            this.statMenu.Text = "Statistika";
            // 
            // xStatMenu
            // 
            this.xStatMenu.Name = "xStatMenu";
            this.xStatMenu.Size = new System.Drawing.Size(224, 26);
            this.xStatMenu.Text = "Statistika X igrača";
            this.xStatMenu.Click += new System.EventHandler(this.xStatMenu_Click);
            // 
            // oStatMenu
            // 
            this.oStatMenu.Name = "oStatMenu";
            this.oStatMenu.Size = new System.Drawing.Size(224, 26);
            this.oStatMenu.Text = "Statistika O igrača";
            // 
            // MainForm4x4x4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(942, 981);
            this.Controls.Add(this.level4Form4);
            this.Controls.Add(this.level4Form3);
            this.Controls.Add(this.level4Form2);
            this.Controls.Add(this.level4Form1);
            this.Controls.Add(this.nbMoveLabel);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.LabelMove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oNameLabel);
            this.Controls.Add(this.xNameLabel);
            this.Controls.Add(this.newMenu);
            this.MainMenuStrip = this.newMenu;
            this.MinimumSize = new System.Drawing.Size(960, 1028);
            this.Name = "MainForm4x4x4";
            this.Text = "Qubic - 4x4x4 varijanta";
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
        private level4Form level4Form1;
        private level4Form level4Form2;
        private level4Form level4Form3;
        private level4Form level4Form4;
        private System.Windows.Forms.ToolStripMenuItem statMenu;
        private System.Windows.Forms.ToolStripMenuItem xStatMenu;
        private System.Windows.Forms.ToolStripMenuItem oStatMenu;
    }
}