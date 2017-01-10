using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablice
{
    public partial class MulitDimeMessageBox : Form
    {
        public int numberOfDimensions;

        public TextBox[] valuesTextBox;
        
        public MulitDimeMessageBox(int numberOfDimensions)
        {
            InitializeComponent();
            this.numberOfDimensions = numberOfDimensions;
            initTextBoxes();
            addTextBoxesToGroupBox();
        }

        public void initTextBoxes()
        {
            valuesTextBox = new TextBox[numberOfDimensions];

            for (int i = 0; i < numberOfDimensions; i++)
            {
                valuesTextBox[i] = new TextBox();
                valuesTextBox[i].Text = "0";
                valuesTextBox[i].Name = i.ToString();
                valuesTextBox[i].Location = new Point(25, 25);
                valuesTextBox[i].Width = 60;
            }
        }

        public void addTextBoxesToGroupBox()
        {
            PositionPanel.Controls.AddRange(valuesTextBox);
           
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Form1.isTransferFromMessageForm = true;
            initPosition();
            this.Close();
        }

        private void initPosition()
        {
            int[] tab = new int[numberOfDimensions];

            int i = 0;
            foreach (TextBox textBox in PositionPanel.Controls)
            {
                tab[i] = Int32.Parse(textBox.Text);
                i++;
            }


            Form1.position = tab;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form1.isTransferFromMessageForm = false;
            this.Close();
        }

        
    }
}
