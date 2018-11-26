using System;

namespace ReSharper20183CSharp.FormatterDetections {
    // ReSharper | Edit | Detect formatting settings
    public class DetectFormatting {
        public void MyMethod() {
            // ...
        }

        public string CurrentHoliday() {
            if (DateTime.Now.Month == 1 && DateTime.Now.Day == 1)
                return "New Year's Day";
            else
                return null;
        }
    }
}