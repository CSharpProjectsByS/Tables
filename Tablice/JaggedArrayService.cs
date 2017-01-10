using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablice
{
    class JaggedArrayService
    {

        private int FirstSize = 0;
        private int SecondSize = 0;
        private int ThirdSize = 0;

        private int x = 0;
        private int y = 0;
        private int z = 0;

        private bool isEndOFTable = false;

        public bool IsEndOFTable { get { return isEndOFTable; } set { isEndOFTable = value; }  }

        private int MultiDimensionalNumber = 0;
        private int[] dimensionsSize;
 
        public void initArray(ref int [][][] array, int x, int y, int z)
        {

            FirstSize = x;
            SecondSize = y;
            ThirdSize = z;

            array = new int[x][][];
            for (int i = 0; i < x; i++)
            {
                array[i] = new int[y][];
                for (int j = 0; j < y; j++)
                {
                    array[i][j] = new int[z];
                }
            }  
        }


        public void putOneValueToAllFields(ref int[][][] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
               for (int j = 0; j < array[0].Length; j++)
                {
                    for (int k = 0; k < array[0][0].Length; k++)
                    {
                        array[i][j][k] = value;
                    }
                }
            }
        }

        public void putValuesFromNToAllFields(ref int[][][] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[0].Length; j++)
                {
                    for (int k = 0; k < array[0][0].Length; k++)
                    {
                        array[i][j][k] = value;
                        value++;
                    }
                }
            }
        }

        public void showArray(ref int [][][] array, ListBox ArrayView)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[0].Length; j++)
                {
                    for (int k = 0; k < array[0][0].Length; k++)
                    {
                        ArrayView.Items.Add("[" + i + "][" + j + "][" + k + "] = " + array[i][j][k]);
                    }
                }
            }
        }

        public void putPointOneByOne(ref int[][][] array, NumericUpDown ValueOfIndex, Label label)
        {
            int value = Int32.Parse(ValueOfIndex.Text);
            array[x][y][z] = value;
            setXYZ(label);
        }


        private void setXYZ(Label label)
        {
            z++;

            if (x == FirstSize - 1 && y == SecondSize - 1 && z == ThirdSize)
            {
                x = 0;
                y = 0;
                z = 0;
                isEndOFTable = true;
            }
            else
            {
                if (z == ThirdSize)
                {
                    z = 0;
                    y++;
                }

                if (y == SecondSize)
                {
                    y = 0;
                    x++;
                }
            }

            label.Text = "[" + x + "][" + y + "][" + z + "]";

        }
    }
}
