namespace Tablice
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
            this.FirstDimensionSize = new System.Windows.Forms.TextBox();
            this.SecondDimensionSize = new System.Windows.Forms.TextBox();
            this.ThirdDimensionSize = new System.Windows.Forms.TextBox();
            this.ArrayDimensionSizeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MultiDimensionalRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangularArrayRadioButton = new System.Windows.Forms.RadioButton();
            this.JaggedArrayRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MultiSizeButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.OneValueForAllRadioButton = new System.Windows.Forms.RadioButton();
            this.InsertValueToTable = new System.Windows.Forms.Button();
            this.ValueOfIndex = new System.Windows.Forms.NumericUpDown();
            this.ArrayView = new System.Windows.Forms.ListBox();
            this.ClearTableViewButton = new System.Windows.Forms.Button();
            this.ShowArray = new System.Windows.Forms.Button();
            this.ValueFromN_RadioButton = new System.Windows.Forms.RadioButton();
            this.ShowElementButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueOfIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstDimensionSize
            // 
            this.FirstDimensionSize.Location = new System.Drawing.Point(18, 32);
            this.FirstDimensionSize.Name = "FirstDimensionSize";
            this.FirstDimensionSize.Size = new System.Drawing.Size(63, 26);
            this.FirstDimensionSize.TabIndex = 2;
            this.FirstDimensionSize.Text = "0";
            // 
            // SecondDimensionSize
            // 
            this.SecondDimensionSize.Location = new System.Drawing.Point(18, 60);
            this.SecondDimensionSize.Name = "SecondDimensionSize";
            this.SecondDimensionSize.Size = new System.Drawing.Size(63, 26);
            this.SecondDimensionSize.TabIndex = 3;
            this.SecondDimensionSize.Text = "0";
            // 
            // ThirdDimensionSize
            // 
            this.ThirdDimensionSize.Location = new System.Drawing.Point(18, 88);
            this.ThirdDimensionSize.Name = "ThirdDimensionSize";
            this.ThirdDimensionSize.Size = new System.Drawing.Size(63, 26);
            this.ThirdDimensionSize.TabIndex = 4;
            this.ThirdDimensionSize.Text = "0";
            // 
            // ArrayDimensionSizeButton
            // 
            this.ArrayDimensionSizeButton.Location = new System.Drawing.Point(6, 145);
            this.ArrayDimensionSizeButton.Name = "ArrayDimensionSizeButton";
            this.ArrayDimensionSizeButton.Size = new System.Drawing.Size(204, 45);
            this.ArrayDimensionSizeButton.TabIndex = 5;
            this.ArrayDimensionSizeButton.Text = "Definiuj rozmiar";
            this.ArrayDimensionSizeButton.UseVisualStyleBackColor = true;
            this.ArrayDimensionSizeButton.Click += new System.EventHandler(this.JaggedArrayDimensionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MultiDimensionalRadioButton);
            this.groupBox1.Controls.Add(this.RectangularArrayRadioButton);
            this.groupBox1.Controls.Add(this.JaggedArrayRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz tablicę";
            // 
            // MultiDimensionalRadioButton
            // 
            this.MultiDimensionalRadioButton.AutoSize = true;
            this.MultiDimensionalRadioButton.Location = new System.Drawing.Point(6, 87);
            this.MultiDimensionalRadioButton.Name = "MultiDimensionalRadioButton";
            this.MultiDimensionalRadioButton.Size = new System.Drawing.Size(155, 24);
            this.MultiDimensionalRadioButton.TabIndex = 1;
            this.MultiDimensionalRadioButton.Text = "Wielowymiarowa";
            this.MultiDimensionalRadioButton.UseVisualStyleBackColor = true;
            this.MultiDimensionalRadioButton.CheckedChanged += new System.EventHandler(this.MultiDimensionalRadioButton_CheckedChanged);
            // 
            // RectangularArrayRadioButton
            // 
            this.RectangularArrayRadioButton.AutoSize = true;
            this.RectangularArrayRadioButton.Location = new System.Drawing.Point(6, 57);
            this.RectangularArrayRadioButton.Name = "RectangularArrayRadioButton";
            this.RectangularArrayRadioButton.Size = new System.Drawing.Size(178, 24);
            this.RectangularArrayRadioButton.TabIndex = 1;
            this.RectangularArrayRadioButton.Text = "Tablica Prostokątna";
            this.RectangularArrayRadioButton.UseVisualStyleBackColor = true;
            this.RectangularArrayRadioButton.CheckedChanged += new System.EventHandler(this.RectangularArrayRadioButton_CheckedChanged);
            // 
            // JaggedArrayRadioButton
            // 
            this.JaggedArrayRadioButton.AutoSize = true;
            this.JaggedArrayRadioButton.Checked = true;
            this.JaggedArrayRadioButton.Location = new System.Drawing.Point(6, 30);
            this.JaggedArrayRadioButton.Name = "JaggedArrayRadioButton";
            this.JaggedArrayRadioButton.Size = new System.Drawing.Size(189, 24);
            this.JaggedArrayRadioButton.TabIndex = 0;
            this.JaggedArrayRadioButton.TabStop = true;
            this.JaggedArrayRadioButton.Text = "Talblica postrzępiona";
            this.JaggedArrayRadioButton.UseVisualStyleBackColor = true;
            this.JaggedArrayRadioButton.CheckedChanged += new System.EventHandler(this.JaggedArrayRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wypełnij tablicę:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Indeks";
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(115, 267);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(62, 20);
            this.IndexLabel.TabIndex = 9;
            this.IndexLabel.Text = "Zerowy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MultiSizeButton);
            this.groupBox2.Controls.Add(this.FirstDimensionSize);
            this.groupBox2.Controls.Add(this.SecondDimensionSize);
            this.groupBox2.Controls.Add(this.ThirdDimensionSize);
            this.groupBox2.Controls.Add(this.ArrayDimensionSizeButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(25, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 299);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wymiar";
            // 
            // MultiSizeButton
            // 
            this.MultiSizeButton.Location = new System.Drawing.Point(6, 203);
            this.MultiSizeButton.Name = "MultiSizeButton";
            this.MultiSizeButton.Size = new System.Drawing.Size(204, 88);
            this.MultiSizeButton.TabIndex = 6;
            this.MultiSizeButton.Text = "Nowy \r\nniestandardowy \r\nrozmiar";
            this.MultiSizeButton.UseVisualStyleBackColor = true;
            this.MultiSizeButton.Click += new System.EventHandler(this.MulitSizeButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.InsertValueToTable);
            this.groupBox3.Controls.Add(this.ValueOfIndex);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.IndexLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(263, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 451);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wypełnij tablice";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ValueFromN_RadioButton);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.OneValueForAllRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 178);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Warriant";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(199, 44);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Wypełni wszytkie pola \r\nróżnymi wartościami";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // OneValueForAllRadioButton
            // 
            this.OneValueForAllRadioButton.AutoSize = true;
            this.OneValueForAllRadioButton.Checked = true;
            this.OneValueForAllRadioButton.Location = new System.Drawing.Point(6, 30);
            this.OneValueForAllRadioButton.Name = "OneValueForAllRadioButton";
            this.OneValueForAllRadioButton.Size = new System.Drawing.Size(212, 44);
            this.OneValueForAllRadioButton.TabIndex = 0;
            this.OneValueForAllRadioButton.TabStop = true;
            this.OneValueForAllRadioButton.Text = "Wypełnij wszystkie pola \r\njedną wartością";
            this.OneValueForAllRadioButton.UseVisualStyleBackColor = true;
            this.OneValueForAllRadioButton.CheckedChanged += new System.EventHandler(this.OneValueForAllRadioButton_CheckedChanged);
            // 
            // InsertValueToTable
            // 
            this.InsertValueToTable.Location = new System.Drawing.Point(12, 355);
            this.InsertValueToTable.Name = "InsertValueToTable";
            this.InsertValueToTable.Size = new System.Drawing.Size(210, 48);
            this.InsertValueToTable.TabIndex = 12;
            this.InsertValueToTable.Text = "Ustaw";
            this.InsertValueToTable.UseVisualStyleBackColor = true;
            this.InsertValueToTable.Click += new System.EventHandler(this.SetValueOfIndex_Click);
            // 
            // ValueOfIndex
            // 
            this.ValueOfIndex.Location = new System.Drawing.Point(51, 303);
            this.ValueOfIndex.Name = "ValueOfIndex";
            this.ValueOfIndex.Size = new System.Drawing.Size(120, 26);
            this.ValueOfIndex.TabIndex = 11;
            // 
            // ArrayView
            // 
            this.ArrayView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ArrayView.FormattingEnabled = true;
            this.ArrayView.ItemHeight = 20;
            this.ArrayView.Location = new System.Drawing.Point(525, 19);
            this.ArrayView.Name = "ArrayView";
            this.ArrayView.Size = new System.Drawing.Size(231, 444);
            this.ArrayView.TabIndex = 12;
            // 
            // ClearTableViewButton
            // 
            this.ClearTableViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClearTableViewButton.Location = new System.Drawing.Point(525, 475);
            this.ClearTableViewButton.Name = "ClearTableViewButton";
            this.ClearTableViewButton.Size = new System.Drawing.Size(231, 63);
            this.ClearTableViewButton.TabIndex = 13;
            this.ClearTableViewButton.Text = "Wyczyść widok";
            this.ClearTableViewButton.UseVisualStyleBackColor = true;
            this.ClearTableViewButton.Click += new System.EventHandler(this.ClearTableViewButton_Click);
            // 
            // ShowArray
            // 
            this.ShowArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowArray.Location = new System.Drawing.Point(262, 475);
            this.ShowArray.Name = "ShowArray";
            this.ShowArray.Size = new System.Drawing.Size(251, 63);
            this.ShowArray.TabIndex = 14;
            this.ShowArray.Text = "Pokaż Tablicę";
            this.ShowArray.UseVisualStyleBackColor = true;
            this.ShowArray.Click += new System.EventHandler(this.ShowArray_Click);
            // 
            // ValueFromN_RadioButton
            // 
            this.ValueFromN_RadioButton.AutoSize = true;
            this.ValueFromN_RadioButton.Location = new System.Drawing.Point(6, 130);
            this.ValueFromN_RadioButton.Name = "ValueFromN_RadioButton";
            this.ValueFromN_RadioButton.Size = new System.Drawing.Size(212, 44);
            this.ValueFromN_RadioButton.TabIndex = 2;
            this.ValueFromN_RadioButton.TabStop = true;
            this.ValueFromN_RadioButton.Text = "Wypełnianie wszystkich \r\npól wartością od n";
            this.ValueFromN_RadioButton.UseVisualStyleBackColor = true;
            this.ValueFromN_RadioButton.CheckedChanged += new System.EventHandler(this.ValueFromN_RadioButton_CheckedChanged);
            // 
            // ShowElementButton
            // 
            this.ShowElementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowElementButton.Location = new System.Drawing.Point(31, 475);
            this.ShowElementButton.Name = "ShowElementButton";
            this.ShowElementButton.Size = new System.Drawing.Size(210, 63);
            this.ShowElementButton.TabIndex = 15;
            this.ShowElementButton.Text = "Pokaż wybrany element\r\n";
            this.ShowElementButton.UseVisualStyleBackColor = true;
            this.ShowElementButton.Click += new System.EventHandler(this.ShowElementButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.Controls.Add(this.ShowElementButton);
            this.Controls.Add(this.ShowArray);
            this.Controls.Add(this.ClearTableViewButton);
            this.Controls.Add(this.ArrayView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tablice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueOfIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FirstDimensionSize;
        private System.Windows.Forms.TextBox SecondDimensionSize;
        private System.Windows.Forms.TextBox ThirdDimensionSize;
        private System.Windows.Forms.Button ArrayDimensionSizeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RectangularArrayRadioButton;
        private System.Windows.Forms.RadioButton JaggedArrayRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button InsertValueToTable;
        private System.Windows.Forms.NumericUpDown ValueOfIndex;
        private System.Windows.Forms.ListBox ArrayView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton OneValueForAllRadioButton;
        private System.Windows.Forms.Button ClearTableViewButton;
        private System.Windows.Forms.Button ShowArray;
        private System.Windows.Forms.Button MultiSizeButton;
        private System.Windows.Forms.RadioButton MultiDimensionalRadioButton;
        private System.Windows.Forms.RadioButton ValueFromN_RadioButton;
        private System.Windows.Forms.Button ShowElementButton;
    }
}

