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
    public partial class ThreeDimensionalPosition : Form
    {
        public ThreeDimensionalPosition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transferPositionToMainForm();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            transferNothingToMainForm();
            this.Close();  
        }

        private void transferPositionToMainForm()
        {
            initValuesOfPosForm1();
            Form1.isTransferFromMessageForm = true;
        }

        private void initValuesOfPosForm1()
        {
            Form1.xPos = Int32.Parse(Position1.Text);
            Form1.yPos = Int32.Parse(Position2.Text);
            Form1.zPos = Int32.Parse(Position3.Text);
        }

        private void transferNothingToMainForm()
        {
            Form1.isTransferFromMessageForm = false;    
        }
    }
}
