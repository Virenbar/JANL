using System;
using System.Data.SqlClient;
using JANL.Data;
using NUnit.Framework;

namespace JANL.Test.Data
{
    internal class SQLDataMapperTest
    {
        private const int I = 0;

        [Test]
        public void FromObject_1()
        {
            var input = new TestObject1
            {
                TestDate = DateTime.Today,
                TestDecimal = 100M,
                TestInteger = 1000,
                TestString = "Aboba"
            };
            var output = new SqlCommand();
            SQLDataMapper.ReadFromObject(input, output.Parameters);
            Assert.That(output.Parameters.Count, Is.EqualTo(4));
            Assert.That(output.Parameters["@TestDate"].Value, Is.EqualTo(input.TestDate));
            Assert.That(output.Parameters["@TestDecimal"].Value, Is.EqualTo(input.TestDecimal));
            Assert.That(output.Parameters["@TestInteger"].Value, Is.EqualTo(input.TestInteger));
            Assert.That(output.Parameters["@TestString"].Value, Is.EqualTo(input.TestString));
        }

        [Test]
        public void FromObject_2()
        {
            var input = new TestObject2
            {
                TestDate_Custom = DateTime.Today,
                TestDecimal = 100M,
                TestInteger = 1000,
                TestString = "Aboba"
            };
            var output = new SqlCommand();
            SQLDataMapper.ReadFromObject(input, output.Parameters);
            Assert.That(output.Parameters.Count, Is.EqualTo(3));
            Assert.That(output.Parameters["@TestDate"].Value, Is.EqualTo(input.TestDate_Custom));
            Assert.That(output.Parameters["@TestInteger"].Value, Is.EqualTo(input.TestInteger));
            Assert.That(output.Parameters["@TestString"].Value, Is.EqualTo(input.TestString));

            void getParameter() { var parameter = output.Parameters["@TestDecimal"]; }
            Assert.That((Action)getParameter, Throws.Exception.TypeOf<IndexOutOfRangeException>());
            //Assert.Throws<IndexOutOfRangeException>((Action)getParameter);
        }

        [Test]
        public void ToObject_1()
        {
            var input = TestData.DataTable.Rows[I];
            var output = SQLDataMapper.WriteToObject<TestObject1>(input);
            Assert.That(output.TestDate, Is.EqualTo(DateTime.Today));
            Assert.That(output.TestDecimal, Is.EqualTo((decimal)I));
            Assert.That(output.TestInteger, Is.EqualTo(I));
            Assert.That(output.TestString, Is.EqualTo($"String {I}"));
        }

        [Test]
        public void ToObject_2()
        {
            var input = TestData.DataTable.Rows[I];
            var output = SQLDataMapper.WriteToObject<TestObject2>(input);
            Assert.That(output.TestDate_Custom, Is.EqualTo(DateTime.Today));
            Assert.That(output.TestDecimal, Is.EqualTo((decimal)I));
            Assert.That(output.TestInteger, Is.Not.EqualTo(I));
            Assert.That(output.TestString, Is.EqualTo($"String {I}"));
        }

        private class TestObject1
        {
            public DateTime? TestDate { get; set; }
            public decimal? TestDecimal { get; set; }
            public int? TestInteger { get; set; }
            public string TestString { get; set; }
        }

        private class TestObject2
        {
            [MapperIgnore]
            public string IgnoreMe { get; set; }

            [MapperColumn("TestDate")]
            public DateTime? TestDate_Custom { get; set; }

            [MapperColumn(WriteOnly = true)]
            public decimal? TestDecimal { get; set; }

            [MapperColumn(ReadOnly = true)]
            public int? TestInteger { get; set; }

            public string TestString { get; set; }
        }
    }
}