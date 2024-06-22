using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlarmVideo_Windows_Form_Application.Models;
using AlarmVideo_Windows_Form_Application.Views;

namespace AlarmVideo_Windows_Form_Application.Presenters
{
    class MessagePresenter
    {
        //create object from model
        Message message = new Message();

        //create instance from interface
        private IMessage messageView;

        //create constructor
        public MessagePresenter(IMessage view)
        {
            messageView = view;
        }

        // method creation to create a connection between model and view
        public void ConnectionModelAndView()
        {
            message.InputMessage = messageView.MessageInput;
        }

        public void GetResultMessage()
        {
            // retrieves extracted numbers from message and does the logic of presentation here
            ConnectionModelAndView();
            messageView.GetResult = message.GetResult();

            // if no error found then assign values to appropriate field ie alarm id and video server no
            if (!messageView.GetResult.StartsWith("Error:-"))
            {
                List<string> getList = messageView.GetResult.Split(',').ToList();

                messageView.ResultMessage = "SUCCESS!!";
                messageView.ExceptionMessage = null;

                if (messageView.MessageInput.StartsWith("Alarm"))
                {
                    messageView.ResultAlarmId = getList[0];
                    messageView.ResultVideoServerNo = getList[1];
                }
                else
                {
                    messageView.ResultAlarmId = getList[1];
                    messageView.ResultVideoServerNo = getList[0];
                }
            }
            else
            {
                // else fail and display appropriate exception message
                messageView.ResultAlarmId = null;
                messageView.ResultVideoServerNo = null;
                messageView.ResultMessage = "FAILED!!";
                messageView.ExceptionMessage = messageView.GetResult;
            }
        }
    }
}
