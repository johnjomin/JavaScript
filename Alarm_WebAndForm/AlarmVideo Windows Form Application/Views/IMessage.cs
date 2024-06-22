using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmVideo_Windows_Form_Application.Views
{
    interface IMessage
    {
        string MessageInput { get; set; }
        string GetResult { get; set; }
        string ResultAlarmId { get; set; }
        string ResultVideoServerNo { get; set; }
        string ResultMessage { get; set; }
        string ExceptionMessage { get; set; }
    }
}
