using System.Data;
using System.Threading.Tasks;
using JANL.Stores;
using NUnit.Framework;

namespace JANL.Test.Data
{
    [SetUpFixture]
    internal static class TestData
    {
        private readonly static TestObjectStore TestStore = new TestObjectStore();
        public static DataTable DataTable { get; set; }

        [OneTimeTearDown]
        public static void RunAfterAnyTests()
        {
            DataTable.Dispose();
        }

        [OneTimeSetUp]
        public async static Task RunBeforeAnyTests()
        {
            DataTable = await TestStore.SelectList();
        }
    }
}