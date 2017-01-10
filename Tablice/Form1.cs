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
    public partial class Form1 : Form
    {
        private int[][][] jaggedTable;
        private int[,,] rectangularTable;
        Array multiDimensionalArray;

        private JaggedArrayService jArrayService = new JaggedArrayService();
        private RectangularArrayService rArrayService = new RectangularArrayService();
        private MulitArrayService mArrayService = new MulitArrayService();

        private bool isJaggedArray = true;
        private bool isRectangularArray = false;
        private bool isMulitDimensionalArray = false;

        private bool isOnePointForAll = true;
        private bool isOnePointForOne = false;
        private bool isValueFromNForAll = false;
        
        private int numberOfDimensions = 0;
        private int[] dimensionsSize;

        public static bool isWait = true;

        public static bool isTransferFromMessageForm = false;
        public static int xPos, yPos, zPos;
        public static int[] position;

        private ThreeDimensionalPosition threeDimForm;
        private MulitDimeMessageBox multiDimeMB;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setActiveControllForMulti(true);
            //MultiSizeButton.Enabled = true;
        }

        private void JaggedArrayDimensionButton_Click(object sender, EventArgs e)
        {
            initProperTable();
            MessageBox.Show("Tablica został zainicjowana prawidłowo");
        }

        private void initProperTable()
        {

            int x = Convert.ToInt32(FirstDimensionSize.Text);
            int y = Convert.ToInt32(SecondDimensionSize.Text);
            int z = Convert.ToInt32(ThirdDimensionSize.Text);


            if (isJaggedArray)
            {
                jArrayService.initArray(ref jaggedTable, x, y, z);
            }

           

            else if (isRectangularArray)
            {
                rArrayService.initArray(ref rectangularTable, x, y, z);
            }

        }


        private void SetValueOfIndex_Click(object sender, EventArgs e)
        {
            chooseCorrectOption();
            
        }

        private void chooseCorrectOption()
        {
            int value = Convert.ToInt16(ValueOfIndex.Text);

            if (isJaggedArray && isOnePointForAll)
            {
                jArrayService.putOneValueToAllFields(ref jaggedTable, value);
                MessageBox.Show("Wartości zostały ustawione.");
            }

            else if (isJaggedArray && isOnePointForOne)
            {
                jArrayService.putPointOneByOne(ref jaggedTable, ValueOfIndex, IndexLabel);
                if (jArrayService.IsEndOFTable)
                {
                    MessageBox.Show("Koniec tablicy.");
                    jArrayService.IsEndOFTable = false;
                }   
            }

            else if (isJaggedArray && isValueFromNForAll)
            {
                jArrayService.putValuesFromNToAllFields(ref jaggedTable, value);
                MessageBox.Show("Wstawiono wartości do tablicy.");
            }

            else if (isRectangularArray && isOnePointForAll)
            {
                MessageBox.Show("Wartości zostały ustawione.");
                rArrayService.putOneValueToAllFields(ref rectangularTable, value);
                MessageBox.Show("Wartości zostały ustawione.");
            }

            else if (isRectangularArray && isOnePointForOne)
            {
                rArrayService.putPointOneByOne(ref rectangularTable, ValueOfIndex, IndexLabel);
                if (rArrayService.IsEndOFTable)
                {
                    MessageBox.Show("Koniec Tablicy.");
                    rArrayService.IsEndOFTable = false;
                }
            }

            else if (isRectangularArray && isValueFromNForAll)
            {
                rArrayService.putValuesFromNToAllFields(ref rectangularTable, value);
                MessageBox.Show("Wartości zostały wstawione.");
            }

            else if (isMulitDimensionalArray && isOnePointForAll)
            {
                mArrayService.putOneValueForAll(ref multiDimensionalArray, value);    
            }

            else if (isMulitDimensionalArray && isOnePointForOne)
            {
                mArrayService.putOneValueOneByOne(ref multiDimensionalArray, value, IndexLabel);
                if (mArrayService.IsEndOfTable)
                {
                    MessageBox.Show("Koniec tablicy.");
                    mArrayService.IsEndOfTable = false;
                }
            }

            else if (isMulitDimensionalArray && isValueFromNForAll)
            {
                mArrayService.putValueFromNForAll(ref multiDimensionalArray, value);
                MessageBox.Show("Wartości zostały wstawione.");
            }
           
        }

        private void ClearTableViewButton_Click(object sender, EventArgs e)
        {
            ArrayView.Items.Clear();
        }

        private void ShowArray_Click(object sender, EventArgs e)
        {
            ArrayView.Items.Clear();
            if (isJaggedArray)
            {
                jArrayService.showArray(ref jaggedTable, ArrayView);
            }
            else if (isRectangularArray)
            {
                rArrayService.showArray(ref rectangularTable, ArrayView);
            }
            else if (isMulitDimensionalArray)
            {
                mArrayService.showArray(ref multiDimensionalArray, ArrayView);
            }
        }

        private void JaggedArrayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (JaggedArrayRadioButton.Checked)
            {
                isJaggedArray = true;
                isRectangularArray = false;
                isMulitDimensionalArray = false;

                setActiveControllForMulti(true);
            }

        }

        private void RectangularArrayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RectangularArrayRadioButton.Checked)
            {
                isRectangularArray = true;
                isJaggedArray = false;
                isMulitDimensionalArray = false;

                setActiveControllForMulti(true);
            }
        }

        private void MultiDimensionalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiDimensionalRadioButton.Checked)
            {
                isMulitDimensionalArray = true;
                isRectangularArray = false;
                isJaggedArray = false;

                setActiveControllForMulti(false);
            }
        }

        private void OneValueForAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OneValueForAllRadioButton.Checked)
            {
                isOnePointForAll = true;
                isOnePointForOne = false;
                isValueFromNForAll = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                isOnePointForOne = true;
                isOnePointForAll = false;
                isValueFromNForAll = false;
            }
        }

        private void ValueFromN_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ValueFromN_RadioButton.Checked)
            {
                isValueFromNForAll = true;
                isOnePointForOne = false;
                isOnePointForAll = false;
            }
        }

        private void MulitSizeButton_Click(object sender, EventArgs e)
        {
            getAllDataToInitMulitTable();
            mArrayService.initArray(ref multiDimensionalArray, numberOfDimensions, dimensionsSize);
        }

        private void getAllDataToInitMulitTable()
        {
            string message = Microsoft.VisualBasic.Interaction.InputBox("Podaj ilosc wymiarów: ", "Iość wymiarów", "Default Response");
            numberOfDimensions = Int32.Parse(message);

            dimensionsSize = new int[numberOfDimensions];
            
            for (int i = 0; i < numberOfDimensions; i++)
            {
                message = Microsoft.VisualBasic.Interaction.InputBox("Podaj rozmiar wymiaru " + (i + 1) 
                    + ": " 
                    , "Rozmiar wymiaru", "Default Response");

                dimensionsSize[i] = Int32.Parse(message);
            } 
        }

        

        

        private void setActiveControllForMulti(bool isActive)
        {
            FirstDimensionSize.Enabled = isActive;
            SecondDimensionSize.Enabled = isActive;
            ThirdDimensionSize.Enabled = isActive;

            ArrayDimensionSizeButton.Enabled = isActive;
            MultiSizeButton.Enabled = !isActive;
        }

        private void ShowElementButton_Click(object sender, EventArgs e)
        {
            if (isJaggedArray)
            {
                showElementOfJaggedArray();    
            }

            else if (isRectangularArray)
            {
                showElementOfRectangularArray();
            }

            else if (isMulitDimensionalArray)
            {
                showElementOfMulitArray();
            }
        }

        private void showElementOfJaggedArray()
        {
            threeDimForm = new ThreeDimensionalPosition();
            threeDimForm.ShowDialog();
            if (isTransferFromMessageForm)
            {
                int value = jaggedTable[xPos][yPos][zPos];
                ArrayView.Items.Clear();
                ArrayView.Items.Add("[" + xPos + "][" + yPos + "][" + zPos + "] = " + value);
            }
        }

        private void showElementOfRectangularArray()
        {
            threeDimForm = new ThreeDimensionalPosition();
            threeDimForm.ShowDialog();
            if (isTransferFromMessageForm)
            {
                int value = rectangularTable[xPos, yPos, zPos];
                ArrayView.Items.Clear();
                ArrayView.Items.Add("[" + xPos + ", " + yPos + ", " + zPos + "] = " + value);
            }
        }

        private void showElementOfMulitArray()
        {
            multiDimeMB = new MulitDimeMessageBox(numberOfDimensions);
            multiDimeMB.ShowDialog();
            if (isTransferFromMessageForm)
            {
                int value = (int)multiDimensionalArray.GetValue(position);
                string message = mArrayService.performItem(position, value);
                ArrayView.Items.Clear();
                ArrayView.Items.Add(message);
            }
        }
    }
}
