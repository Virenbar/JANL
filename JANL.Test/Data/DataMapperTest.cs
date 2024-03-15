using JANL.Data;
using JANL.Models;
using NUnit.Framework;
using System;

namespace JANL.Test.Data
{
    internal class DataMapperTest
    {
        [Test]
        public void ToObject()
        {
            var mapper = new DataMapper<TestObjectData>();
            var O = mapper.ToObject(TestData.DataTable.Rows[0]);
            Assert.That(O.TestDate, Is.EqualTo(DateTime.Today));
        }

        [Test]
        public void ToList()
        {
            var mapper = new DataMapper<TestObjectData>();
            var O = mapper.ToObject(TestData.DataTable);
            Assert.That(O[0].TestDate, Is.EqualTo(DateTime.Today));
        }
    }
}