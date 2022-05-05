using JANL.Helpers;
using NUnit.Framework;

namespace JANL.Test.Helpers
{
    public class FilterHelperTest
    {
        [Test]
        public void RowFilterByColumns()
        {
            var Filter = "(Convert(C1,'System.String') LIKE '%V1%' AND Convert(C1,'System.String') LIKE '%V2%') OR (Convert(C2,'System.String') LIKE '%V1%' AND Convert(C2,'System.String') LIKE '%V2%')";
            var F = FilterHelper.RowFilterByColumns(new[] { "C1", "C2" }, "V1 V2");
            Assert.AreEqual(Filter, F);
        }

        [Test]
        public void RowFilterByRow()
        {
            var Filter = "Convert(C1,'System.String')+' '+Convert(C2,'System.String') LIKE '%V1%' AND Convert(C1,'System.String')+' '+Convert(C2,'System.String') LIKE '%V2%'";
            var F = FilterHelper.RowFilterByRow(new[] { "C1", "C2" }, "V1 V2");
            Assert.AreEqual(Filter, F);
        }

        [SetUp]
        public void Setup() { }
    }
}