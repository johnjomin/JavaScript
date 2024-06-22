// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
const init = function () {
    document.getElementById('button-submit').addEventListener('click', submit);
}

const submit = function (ev) {

    try {
        let checkMessage = document.getElementById('input-message').value;

        var addList = [];

        var numberPattern = /\d+/g;

        var shows = checkMessage.match(numberPattern);
        checkMessage = checkMessage.toLowerCase();

        if (checkMessage.includes("Alarm".toLowerCase()) && checkMessage.includes("Video".toLowerCase())) {
            //resultBar.Text = "SUCCESS";
            if (checkMessage.startsWith("Alarm".toLowerCase())) {
                document.getElementById('input-alarm').value = shows[0];
                document.getElementById('input-video').value = shows[1];
            }
            else {
                document.getElementById('input-alarm').value = shows[1];
                document.getElementById('input-video').value = shows[0];
            }
        }
        else {
            //        throw new Exception("Text not found in string");
        }
    }
    catch (err) {
        var jas = err;
    }


    document.getElementById('form-user').submit();
}

document.addEventListener('DOMContentLoaded', init);




//catch (Exception ex)
//{
//    exceptionLabel.Visible = true;
//    resultException.Visible = true;
//    resultBar.Text = "FAILED";
//    if (ex.Message.StartsWith("Index was out of range")) {
//        resultException.Text = "No digits found in the text field";
//    }
//    else if (ex.Message.StartsWith("Text not found in string")) {
//        resultException.Text = "Alarm and Video text not found in message box";
//    }
//    else {
//        resultException.Text = ex.Message;
//    }

//}