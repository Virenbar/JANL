using JANL.Helpers;
using NUnit.Framework;

namespace JANL.Test.Helpers
{
    public class FilterHelperTest
    {
        [Test]
        public void RowFilterByColumns()
        {
            var target = "(Convert(C1,'System.String') LIKE '%V1%' AND Convert(C1,'System.String') LIKE '%V2%') OR (Convert(C2,'System.String') LIKE '%V1%' AND Convert(C2,'System.String') LIKE '%V2%')";
            var result = FilterHelper.RowFilterByColumns(new[] { "C1", "C2" }, "V1 V2");
            Assert.That(result, Is.EqualTo(target));
        }

        [Test]
        public void RowFilterByRow()
        {
            var target = "Convert(C1,'System.String')+' '+Convert(C2,'System.String') LIKE '%V1%' AND Convert(C1,'System.String')+' '+Convert(C2,'System.String') LIKE '%V2%'";
            var result = FilterHelper.RowFilterByRow(new[] { "C1", "C2" }, "V1 V2");
            Assert.That(result, Is.EqualTo(target));
        }
    }
}