namespace TheCommissar
{
    partial class bpModForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bpModForm));
            this.bpModLabel = new System.Windows.Forms.Label();
            this.bpChangeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bpValueBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bpValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bpModLabel
            // 
            this.bpModLabel.AutoSize = true;
            this.bpModLabel.Location = new System.Drawing.Point(84, 20);
            this.bpModLabel.Name = "bpModLabel";
            this.bpModLabel.Size = new System.Drawing.Size(35, 13);
            this.bpModLabel.TabIndex = 0;
            this.bpModLabel.Text = "label1";
            this.bpModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bpModLabel.Click += new System.EventHandler(this.bpModLabel_Click);
            // 
            // bpChangeButton
            // 
            this.bpChangeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bpChangeButton.Location = new System.Drawing.Point(87, 73);
            this.bpChangeButton.Name = "bpChangeButton";
            this.bpChangeButton.Size = new System.Drawing.Size(75, 23);
            this.bpChangeButton.TabIndex = 2;
            this.bpChangeButton.Text = "Change BP";
            this.bpChangeButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(168, 73);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // bpValueBox
            // 
            this.bpValueBox.Location = new System.Drawing.Point(87, 42);
            this.bpValueBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.bpValueBox.Name = "bpValueBox";
            this.bpValueBox.Size = new System.Drawing.Size(156, 20);
            this.bpValueBox.TabIndex = 4;
            this.bpValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bpModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 114);
            this.Controls.Add(this.bpValueBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bpChangeButton);
            this.Controls.Add(this.bpModLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bpModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.bpValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bpModLabel;
        private System.Windows.Forms.Button bpChangeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown bpValueBox;
    }
}