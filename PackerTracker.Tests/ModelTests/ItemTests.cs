using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.TestTools
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
        Item newItem = new Item("Test");
        Assert.AreEqual(typeof(Item), newItem.GetType());
    }  

    [TestMethod]
    public void GetItemName_ReturnsItemName_String()
    {
        string myItem = "backpack";
        Item newItem = new Item(myItem);
        string result = newItem.Stuff;
        Assert.AreEqual (myItem, result);
    }
  }
}