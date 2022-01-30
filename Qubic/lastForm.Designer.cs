
namespace Qubic
{
    partial class lastForm
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
            this.nameWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Igra je gotova!";
            // 
            // nameWinner
            // 
            this.nameWinner.AutoSize = true;
            this.nameWinner.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameWinner.Location = new System.Drawing.Point(72, 213);
            this.nameWinner.Name = "nameWinner";
            this.nameWinner.Size = new System.Drawing.Size(340, 59);
            this.nameWinner.TabIndex = 1;
            this.nameWinner.Text = "Pobjedio je ";
            // 
            // lastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameWinner);
            this.Controls.Add(this.label1);
            this.Name = "lastForm";
            this.Text = "Kraj igre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameWinner;
    }
}