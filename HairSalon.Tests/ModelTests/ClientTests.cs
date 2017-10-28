using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTests : IDisposable
  {
    public ClientTests()
    {
        DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=saneyee_sarkar_test;";
    }

    public void Dispose()
    {
      Client.DeleteAll();
      Stylist.DeleteAll();
    }

    [TestMethod]
    public void GetAll_DatabaseEmptyAtFirst_0()
    {
      //Arrange, Act
      int result = Client.GetAll().Count;

      //Assert
      Assert.AreEqual(0, result);
    }

    // [TestMethod]
    // public void Equals_OverrideTrueIfClientsAreTheSame_Client()
    // {
    //   // Arrange, Act
    //   Client firstClient = new Client("Taco Bell",1);
    //   Client secondClient = new Client("Taco Bell",1);
    //
    //   // Assert
    //   Assert.AreEqual(firstClient, secondClient);
    // }
    //
    // [TestMethod]
    // public void Save_SavesToDatabase_ClientList()
    // {
    //   //Arrange
    //   Client testClient = new Client("Taco Bell",1);
    //
    //   //Act
    //   testClient.Save();
    //   List<Client> result = Client.GetAll();
    //   List<Client> testList = new List<Client>{testClient};
    //
    //   //Assert
    //   CollectionAssert.AreEqual(testList, result);
    // }
    //
    // [TestMethod]
    // public void Save_AssignsIdToObject_Id()
    // {
    //   //Arrange
    //   Client testClient = new Client("Taco Bell",1);
    //
    //   //Act
    //   testClient.Save();
    //   Client savedClient = Client.GetAll()[0];
    //
    //   int result = savedClient.GetId();
    //   int testId = testClient.GetId();
    //
    //   //Assert
    //   Assert.AreEqual(testId, result);
    // }
    //
    // [TestMethod]
    // public void Find_FindsClientInDatabase_Client()
    // {
    //   //Arrange
    //   Client testClient = new Client("Taco Bell",1);
    //   testClient.Save();
    //
    //   //Act
    //   Client foundClient = Client.Find(testClient.GetId());
    //
    //   //Assert
    //   Assert.AreEqual(testClient, foundClient);
    // }
    // [TestMethod]
    // public void Update_UpdatesClientInDatabase_String()
    // {
    //   //Arrange
    //   string restaurantName = "Japonessa";
    //   Client testClient = new Client(restaurantName, 1);
    //   testClient.Save();
    //   string newClientName = "Taco Bell";
    //
    //   //Act
    //   testClient.UpdateClientName(newClientName);
    //
    //   string result = Client.Find(testClient.GetId()).GetClientName();
    //
    //   //Assert
    //   Assert.AreEqual(newClientName, result);
    // }
    //
    // [TestMethod]
    // public void DeleteClient_DeleteClientInDatabase_Null()
    // {
    //   //Arrange
    //   string restaurantName = "Taco Bell";
    //   Client testClient = new Client(restaurantName, 1);
    //   testClient.Save();
    //   // string deletedClient = "";
    //
    //   //Act
    //   testClient.DeleteClient();
    //   int result = Client.GetAll().Count;
    //
    //   //Assert
    //   Assert.AreEqual(0, result);
    //
    // }
  }
}
