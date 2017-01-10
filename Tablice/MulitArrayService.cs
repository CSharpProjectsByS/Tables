using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablice
{
    class MulitArrayService
    {
        private int numberOfDimensions;
        private int[] dimensionsSize;

        private bool isEndOfTable;

        int[] indexG;

        public bool IsEndOfTable
        {
            get { return isEndOfTable; }
            set { isEndOfTable = value; }
        }

        public void initArray(ref Array array, int numberOfDimensions, int[] dimensionsSize)
        {
            this.numberOfDimensions = numberOfDimensions;
            this.dimensionsSize = dimensionsSize;

            indexG = new int[numberOfDimensions];

            for (int i = 0; i < numberOfDimensions; i++)
            {
                indexG[i] = 0;
            }

            array = Array.CreateInstance(typeof(int), dimensionsSize);
        }

        public void putOneValueForAll(ref Array array, int value)
        {

            int[] index = new int[numberOfDimensions];

            for (int i = 0; i < numberOfDimensions; i++)
            {
                index[i] = 0;
            }


            isEndOfTable = false;

            while (!isEndOfTable)
            {
                array.SetValue(value, index);
                index[numberOfDimensions - 1]++;
                index = returnPosition(index);
                isEndOfTable = checkEndOfTable(index);
            }

        }

        public void putValueFromNForAll(ref Array array, int value)
        {

            int[] index = new int[numberOfDimensions];

            for (int i = 0; i < numberOfDimensions; i++)
            {
                index[i] = 0;
            }


            isEndOfTable = false;

            while (!isEndOfTable)
            {
                array.SetValue(value, index);
                value++;
                index[numberOfDimensions - 1]++;
                index = returnPosition(index);
                isEndOfTable = checkEndOfTable(index);
            }

        }

        public void putOneValueOneByOne(ref Array array, int value, Label indexLabel)
        { 
            array.SetValue(value, indexG);
            indexG[numberOfDimensions - 1]++;
            indexG = returnPosition(indexG);
            isEndOfTable = checkEndOfTable(indexG);

            resetFirstValueOfIndexPoz();

            indexLabel.Text = performLabel(indexG);

        }

        public bool checkEndOfTable(int[] index)
        {
            bool isEnd = false;
            if (index[0] == dimensionsSize[0])
            {
                isEnd = true;
                Console.WriteLine("Koniec tablicy");
            }

            return isEnd;
        }

        private int[] returnPosition(int[] position)
        {
            for (int i = numberOfDimensions - 1; i > 0; i--)
            {
                
                if (position[i] == dimensionsSize[i])
                {
                    position[i] = 0;
                    position[i - 1]++;
                }

            }


            return position;
        }

        private void resetFirstValueOfIndexPoz()
        {

            if (indexG[0] == dimensionsSize[0])
            {
                indexG[0] = 0;
            }

        }

        public void showArray(ref Array array, ListBox ArrayView)
        {
            int[] index = new int[numberOfDimensions];

            for (int i = 0; i < numberOfDimensions; i++)
            {
                index[i] = 0;
            }


            isEndOfTable = false;
            int value = 0;

            while (!isEndOfTable)
            {
                value = (int) array.GetValue(index);
                String item = performItem(index, value);
                ArrayView.Items.Add(item);
                index[numberOfDimensions - 1]++;
                index = returnPosition(index);
                isEndOfTable = checkEndOfTable(index);
            }
        }

        public string performItem(int[] index, int value)
        {
            string item = "[";
            for (int i = 0; i < index.Length;  i++)
            {
                if (i == index.Length - 1)
                {
                    item += index[i] + "]";
                }
                else
                {
                    item += index[i] + "][";
                }
            }

            item += " = " + value;

            return item;
        }

        private string performLabel(int[] index)
        {
            string label = "[";
            for (int i = 0; i < index.Length; i++)
            {
                if (i == index.Length - 1)
                {
                    label += index[i] + "]";
                }
                else
                {
                    label += index[i] + "][";
                }
            }

            return label;
        }
    }
}
