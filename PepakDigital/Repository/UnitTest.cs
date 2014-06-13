using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PepakDigital;
using PepakDigital.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PepakDigital
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void HanacarakaRepositoryMock_Find()
        {
            // Arrange
            HancarakaRepositoryMock hrm = new HancarakaRepositoryMock();

            // Act
            Hanacaraka result = hrm.Find(4);

            // Assert
            Assert.AreEqual(4, result.HanacarakaId, "Should be 4");
        }
        
      
        [TestMethod]
        public void KawruhBasaRepositoryMock_Find()
        {
            // Arrange
            KawruhBasaRepositoryMock kb = new KawruhBasaRepositoryMock();

            // Act
            KawruhBasa result = kb.Find(3);

            // Assert
            Assert.AreEqual(3, result.KawruhBasaId, "Should be 3");
        }
        [TestMethod]
        public void KewanRepositoryMock_Find()
        {
            // Arrange
            KewanRepositoryMock kw = new KewanRepositoryMock();

            // Act
            Kewan result = kw.Find(3);

            // Assert
            Assert.AreEqual(3, result.KewanId, "Should be 3");
        }
         [TestMethod]
        public void ParamasastraBasaRepositoryMock_Find()
        {
            // Arrange
            KawruhBasaRepositoryMock kb = new KawruhBasaRepositoryMock();

            // Act
            KawruhBasa result = kb.Find(3);

            // Assert
            Assert.AreEqual(3, result.KawruhBasaId, "Should be 3");
        }
        [TestMethod]
        public void ParibasanRepositoryMock_Find()
        {
            // Arrange
            ParibasanRepositoryMock kb = new ParibasanRepositoryMock();

            // Act
            Paribasan result = kb.Find(3);

            // Assert
            Assert.AreEqual(3, result.ParibasanId, "Should be 3");
        }
         [TestMethod]
        public void ParikanRepositoryMock_Find()
        {
            // Arrange
            ParikanRepositoryMock kb = new ParikanRepositoryMock();

            // Act
            Parikan result = kb.Find(3);

            // Assert
            Assert.AreEqual(3, result.ParikanId, "Should be 3");
        }

         [TestMethod]
         public void WayangRepositoryMock_Find()
         {
             // Arrange
             WayangRepositoryMock kb = new WayangRepositoryMock();

             // Act
             Wayang result = kb.Find(3);

             // Assert
             Assert.AreEqual(3, result.WayangId, "Should be 3");
         }

    }
}