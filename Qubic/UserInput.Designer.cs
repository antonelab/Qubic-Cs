
namespace Qubic
{
    partial class UserInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.xComputer = new System.Windows.Forms.CheckBox();
            this.xName = new System.Windows.Forms.TextBox();
            this.oName = new System.Windows.Forms.TextBox();
            this.oComputer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upišite ime X igrača:";
            // 
            // xComputer
            // 
            this.xComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.xComputer.AutoSize = true;
            this.xComputer.Location = new System.Drawing.Point(92, 92);
            this.xComputer.Name = "xComputer";
            this.xComputer.Size = new System.Drawing.Size(155, 21);
            this.xComputer.TabIndex = 1;
            this.xComputer.Text = "Igraj protiv računala";
            this.xComputer.UseVisualStyleBackColor = true;
            this.xComputer.CheckedChanged += new System.EventHandler(this.xComputer_CheckedChanged);
            // 
            // xName
            // 
            this.xName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.xName.Location = new System.Drawing.Point(98, 64);
            this.xName.Name = "xName";
            this.xName.Size = new System.Drawing.Size(131, 22);
            this.xName.TabIndex = 2;
            this.xName.TextChanged += new System.EventHandler(this.xName_TextChanged);
            // 
            // oName
            // 
            this.oName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.oName.Location = new System.Drawing.Point(98, 174);
            this.oName.Name = "oName";
            this.oName.Size = new System.Drawing.Size(131, 22);
            this.oName.TabIndex = 5;
            this.oName.TextChanged += new System.EventHandler(this.oName_TextChanged);
            // 
            // oComputer
            // 
            this.oComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.oComputer.AutoSize = true;
            this.oComputer.Location = new System.Drawing.Point(87, 202);
            this.oComputer.Name = "oComputer";
            this.oComputer.Size = new System.Drawing.Size(155, 21);
            this.oComputer.TabIndex = 4;
            this.oComputer.Text = "Igraj protiv računala";
            this.oComputer.UseVisualStyleBackColor = true;
            this.oComputer.CheckedChanged += new System.EventHandler(this.oComputer_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Upišite ime O igrača:";
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oName);
            this.Controls.Add(this.oComputer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xName);
            this.Controls.Add(this.xComputer);
            this.Controls.Add(this.label1);
            this.Name = "UserInput";
            this.Size = new System.Drawing.Size(341, 257);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox xComputer;
        private System.Windows.Forms.TextBox xName;
        private System.Windows.Forms.TextBox oName;
        private System.Windows.Forms.CheckBox oComputer;
        private System.Windows.Forms.Label label2;
    }
}
