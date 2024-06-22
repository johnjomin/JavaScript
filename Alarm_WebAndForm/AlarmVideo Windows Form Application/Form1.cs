using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlarmVideo_Windows_Form_Application.Views;
using AlarmVideo_Windows_Form_Application.Presenters;

namespace AlarmVideo_Windows_Form_Application
{
    public partial class Form1 : Form, IMessage
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autoCompleteInputMessage();
        }

        // Adding Interface 'IMessage' members to class
        public string MessageInput { get => userInputText.Text; set => userInputText.Text = value; }
        public string ResultAlarmId { get => alarmIdResultBox.Text; set => alarmIdResultBox.Text = value; }
        public string ResultVideoServerNo { get => videoServerResultBox.Text; set => videoServerResultBox.Text = value; }
        public string ResultMessage { get => resultBar.Text; set => resultBar.Text = value; }
        public string ExceptionMessage { get => resultException.Text; set => resultException.Text = value; }

        public string GetResult { get; set; }

        private MessagePresenter presenter;

        private void enterMessage_Click(object sender, EventArgs e)
        {
            // Using MVP (Model View Presenter pattern)
            presenter = new MessagePresenter(this);
            presenter.GetResultMessage();

            // hide away exception tags if pass
            exceptionLabel.Visible = false;
            resultException.Visible = false;
            resultBar.BackColor = Color.Green;
            // else open them with appropriate message.
            if (!string.IsNullOrEmpty(ExceptionMessage))
            {
                resultBar.BackColor = Color.DarkRed;
                exceptionLabel.Visible = true;
                resultException.Visible = true;
            }
        }

        private void autoCompleteInputMessage()
        {
            string[] message = { "The alarm id from video server number 7 is 10.", "Alarm id 10 has been received from video server number 7.", "The alarm id from video server number 10 is 25.", "Alarm id 40 has been received from video server number 22." };
            
            userInputText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            userInputText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            userInputText.AutoCompleteCustomSource.AddRange(message);

        }
    }
}
