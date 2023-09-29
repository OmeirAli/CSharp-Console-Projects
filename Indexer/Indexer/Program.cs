using System;

namespace Indexer
{
    class TempRecord
    {
        private float[] temps = new float[5] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F };

        public int Length
        {
            get { return temps.Length; }

        }
        public float this[int index]
        {
            get
            {
                if (index < Length)
                {
                    return temps[index];  
                }
                else
                {
                    throw new IndexOutOfRangeException("Index should be in range 0 to 4");
                }

                
            }
            set
            {
                if (index < Length)
                {
                    temps[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index should be in range 0 to 4");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TempRecord tempRecord = new TempRecord();
            tempRecord[0] = 87.5F;
            tempRecord[1] = 78.2F;
            for (int i = 0; i < tempRecord.Length; i++)
            {
                Console.WriteLine("Element #{0} = {1}", i ,tempRecord[i]);
            }
        }
    }
}