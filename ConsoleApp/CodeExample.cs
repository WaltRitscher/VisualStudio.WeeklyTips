using System;
//using WeeklyTips.HardwareChip;

//using HW = WeeklyTips.HardwareChip;
namespace WeeklyTips.ConsoleApp {
  internal class CodeExample {
    public void RunExample() {
      // write the example code here...

      var appVersion = new System.Version();
      var chipVersion = new WeeklyTips.HardwareChip.Version();

      // get the app version
      var major = appVersion.Major;

      // get the OS version
      var os = chipVersion.EmbeddedOS;

    }
  }
}