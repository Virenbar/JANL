using System;

namespace JANL.Models
{
    public class TestObject : ObservableObject
    {
        private TestObjectData data;

        public TestObject()
        {
            data = new TestObjectData();
        }

        #region Properties

        public DateTime? TestDate
        {
            get => data.TestDate;
            set
            {
                if (data.TestDate == value) { return; }
                data.TestDate = value;
                NotifyPropertyChanged();
            }
        }

        public decimal? TestDecimal
        {
            get => data.TestDecimal;
            set
            {
                if (data.TestDecimal == value) { return; }
                data.TestDecimal = value;
                NotifyPropertyChanged();
            }
        }

        public int? TestInteger
        {
            get => data.TestInteger;
            set
            {
                if (data.TestInteger == value) { return; }
                data.TestInteger = value;
                NotifyPropertyChanged();
            }
        }

        public string TestString
        {
            get => data.TestString;
            set
            {
                if (data.TestString == value) { return; }
                data.TestString = value;
                NotifyPropertyChanged();
            }
        }

        #endregion Properties
    }

    public class TestObjectData
    {
        public DateTime? TestDate { get; set; }
        public decimal? TestDecimal { get; set; }
        public int? TestInteger { get; set; }
        public string TestString { get; set; }
    }
}