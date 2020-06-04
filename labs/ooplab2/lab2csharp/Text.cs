using System;
//using System.Collections.Generic;
//using System.Text;

namespace lab2csharp
{
    class Text
    {
        Mystring[] mystrings;
        int size;

        public void AddString(Mystring str)
        {
            size++;
            Array.Resize(ref mystrings, size);
            mystrings[size - 1] = str;
        }
        public void RemoveString(int index)
        {
            if (index <= size)
            {
                size--;
                var newData = new Mystring[mystrings.Length - 1];
                for (int i = 0; i < index-1; i++)
                {
                    newData[i] = mystrings[i];
                }
                for (int i = index-1; i < newData.Length; i++)
                {
                    newData[i] = mystrings[i + 1];
                }
                mystrings = newData;
            }
        }
        public void Replace(int index, Mystring str)
        {
            mystrings[index-1] = str;
        }
        public void Erase()
        {
            var newData = new Mystring[0];
            mystrings = newData;
            size = 0;
        }
        public int Numberofcolums()
        {
            return size;
        }
        public string NumbersinText()
        {
            string str = "";
            foreach(var item in mystrings)
            {
                str += item.Numbers();
            }
            return str;
        }
    }
}
