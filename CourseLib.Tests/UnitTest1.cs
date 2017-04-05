using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourseLib.Tests {
  [TestClass]
  public class GettingATourStop_Should {
    [TestMethod]
    public void ReturnCorrectItem_WhenQueriedByName() {

      // given
      var name = "Buckingham Fountain";

      // when
      var result = CourseLib.Models.TourSource.GetByName(name);
      // then
      Assert.AreEqual(name, result.Name);
    }
  }
}
