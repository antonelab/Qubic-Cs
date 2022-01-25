
namespace Qubic
{
    partial class IntroForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userInput1 = new Qubic.UserInput();
            this.start3 = new System.Windows.Forms.Button();
            this.start4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli u igru Qubic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upišite podatke i započnite igru";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userInput1
            // 
            this.userInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.userInput1.Location = new System.Drawing.Point(194, 128);
            this.userInput1.Name = "userInput1";
            this.userInput1.Size = new System.Drawing.Size(341, 252);
            this.userInput1.TabIndex = 4;
            // 
            // start3
            // 
            this.start3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start3.Location = new System.Drawing.Point(225, 401);
            this.start3.Name = "start3";
            this.start3.Size = new System.Drawing.Size(175, 44);
            this.start3.TabIndex = 5;
            this.start3.Text = "Pokreni igru 3x3x3";
            this.start3.UseVisualStyleBackColor = false;
            this.start3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.start3_MouseClick);
            // 
            // start4
            // 
            this.start4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start4.Location = new System.Drawing.Point(428, 401);
            this.start4.Name = "start4";
            this.start4.Size = new System.Drawing.Size(170, 44);
            this.start4.TabIndex = 6;
            this.start4.Text = "Pokreni igru 4x4x4";
            this.start4.UseVisualStyleBackColor = false;
            this.start4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.start4_MouseClick);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.start4);
            this.Controls.Add(this.start3);
            this.Controls.Add(this.userInput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IntroForm";
            this.Text = "Igra Qubic - odabir igrača";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UserInput userInput1;
        private System.Windows.Forms.Button start3;
        private System.Windows.Forms.Button start4;
    }
}

