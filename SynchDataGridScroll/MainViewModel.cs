using System.Collections.Generic;

namespace SynchDataGridScroll
{
    public class DataClass
    {
        public DataClass(string value1, string value2, string value3)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
    }
    public class MainViewModel
    {
        public MainViewModel()
        {
            Data1 = new List<DataClass>();
            for (int i = 0; i < 20; i++)
            {
                Data1.Add(new DataClass("data1" + i, "data1" + (i + 1), "data1" + (i + 2)));
            }
            Data2 = new List<DataClass>();
            for (int i = 0; i < 50; i++)
            {
                Data2.Add(new DataClass("data2" + i, "data2" + (i + 1), "data2" + (i + 2)));
            }
        }
        public List<DataClass> Data1 { get; set; }
        public List<DataClass> Data2 { get; set; }
    }
}
