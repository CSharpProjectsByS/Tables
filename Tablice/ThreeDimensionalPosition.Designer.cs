namespace Tablice
{
    partial class ThreeDimensionalPosition
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
            this.Position1 = new System.Windows.Forms.TextBox();
            this.Position2 = new System.Windows.Forms.TextBox();
            this.Position3 = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj pozycję:";
            // 
            // Position1
            // 
            this.Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Position1.Location = new System.Drawing.Point(15, 56);
            this.Position1.Name = "Position1";
            this.Position1.Size = new System.Drawing.Size(77, 26);
            this.Position1.TabIndex = 1;
            this.Position1.Text = "0";
            this.Position1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Position2
            // 
            this.Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Position2.Location = new System.Drawing.Point(98, 56);
            this.Position2.Name = "Position2";
            this.Position2.Size = new System.Drawing.Size(90, 26);
            this.Position2.TabIndex = 2;
            this.Position2.Text = "0";
            this.Position2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Position3
            // 
            this.Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Position3.Location = new System.Drawing.Point(194, 56);
            this.Position3.Name = "Position3";
            this.Position3.Size = new System.Drawing.Size(79, 26);
            this.Position3.TabIndex = 3;
            this.Position3.Text = "0";
            this.Position3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OKButton.Location = new System.Drawing.Point(157, 110);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(113, 50);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelButton.Location = new System.Drawing.Point(15, 110);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 50);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ThreeDimensionalPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 186);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Position3);
            this.Controls.Add(this.Position2);
            this.Controls.Add(this.Position1);
            this.Controls.Add(this.label1);
            this.Name = "ThreeDimensionalPosition";
            this.Text = "ThreeDimensionalPosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Position1;
        private System.Windows.Forms.TextBox Position2;
        private System.Windows.Forms.TextBox Position3;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}