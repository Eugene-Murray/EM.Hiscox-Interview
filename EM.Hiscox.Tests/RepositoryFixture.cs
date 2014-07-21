using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EM.Hiscox.Data;

namespace EM.Hiscox.Tests
{
    [TestClass]
    public class RepositoryFixture
    {
        [TestMethod]
        public void GetStations_BySearchTerm_Success()
        {
            // Assign
            var repository = new Repository();
            var expecteCount = 5;

            // Act
            var actualResult = repository.GetSations("da").ToList();

            // Assert
            Assert.AreEqual(expecteCount, actualResult.Count);
        }
    }
}
