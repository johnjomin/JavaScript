using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AlarmVideo_Windows_Form_Application.Models
{
    public class Message
    {
        public string InputMessage { get; set; }

        // Extraction of numbers from input message to be private so it can be protected
        private List<int> ExtractNumbers()
        {
            List<int> listofNumbers = new List<int>();
            // Split on one or more non-digit characters.
            string[] numbers = Regex.Split(InputMessage, @"\D+");
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    listofNumbers.Add(i);
                }
            }
            return listofNumbers;
        }

        // function to display result in string format for MessagePresenter.cs to distinguish if list has been passed
        // else it would display appropriate message in catch exception
        public string GetResult()
        {
            var listNo = ExtractNumbers();
            InputMessage = InputMessage.ToLower();
            try
            {
                if (InputMessage.Contains("alarm") && InputMessage.Contains("video"))
                {
                    string combinedList = string.Join(",", listNo);
                    if (string.IsNullOrEmpty(combinedList))
                    {
                        throw new Exception("Result is Empty");
                    }
                    return combinedList;
                }
                else
                {
                    throw new Exception("Text not found in string");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Result is Empty")
                {
                    return "Error:- No digits found in the text field";
                }
                else if (ex.Message.StartsWith("Text not found"))
                {
                    return "Error:- Alarm and Video text not found in message box";
                }
                else
                {
                    return "Error:- " + ex.Message;
                }

            }
        }
    }
}
