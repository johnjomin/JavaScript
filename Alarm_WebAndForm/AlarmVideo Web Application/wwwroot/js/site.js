// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var mySingleton = (function () {
    // Instance stores a reference to the Singleton
    var instance;

    function init() {
        // Singleton
        // Private methods and variables
        function getExtractMessage(message) {
            var regixNumberPattern = /\d+/g;
            var listofNumbers = message.match(regixNumberPattern);
            return listofNumbers;
        }
        function getAlarmId(val) {
            document.getElementById('input-alarm').value = val;
        }
        function getVideoServerNo(val) {
            document.getElementById('input-video').value = val;
        }
        function getResultMessage(val) {
            document.getElementById('input-resultMessage').value = val;
        }
        function getExceptionMessage(val) {
            document.getElementById("input-exceptionMessage").value = val;
        }

        function getExceptionVisibility(val) {
            if (val == "visible") {
                document.getElementById('alarm-video-request').reset();
                document.getElementById('input-resultMessage').style.backgroundColor = "red";
                document.getElementById("exceptionMessageLabel").style.visibility = val;
                document.getElementById("input-exceptionMessage").style.visibility = val;
            }
            else {
                document.getElementById('input-resultMessage').style.backgroundColor = "green";
                document.getElementById("exceptionMessageLabel").style.visibility = val;
                document.getElementById("input-exceptionMessage").style.visibility = val;
            }
        }

        return {
            //Public methods and variables
            publicProperty: "I am also public property",
            setExtractMessage: function (message) {
                return getExtractMessage(message);
            },
            setAlarmId: function (val) {
                return getAlarmId(val);
            },
            setVideoServerNo: function (val) {
                return getVideoServerNo(val);
            },
            setResultMessage: function (val) {
                return getResultMessage(val);
            },
            setExceptionMessage: function (val) {
                return getExceptionMessage(val);
            },
            setExceptionVisibility: function (val) {
                return getExceptionVisibility(val);
            }
        };
    };
    return {
        // Get the Singleton Instance if one exist
        // or create one if it doesnt exist.
        getInstance: function () {
            if (!instance) {
                instance = init();
            }
            return instance;
        }
    };
})();

let form = document.getElementById("alarm-video-request");


form.addEventListener('submit', (e) => {
    e.preventDefault();
})

function validate()
{
    try
    {
        // Get single instance
        var singletonInstance = mySingleton.getInstance();

        // validate input message through ExtractMethod method publicily available
        var checkMessage = document.getElementById('input-message').value;
        var resultofExtraction = singletonInstance.setExtractMessage(checkMessage);
        

        // Set it to lower case to ignore case sensitive
        checkMessage = checkMessage.toLowerCase();

        // Setting values to the appropriate values to Alarm Id and Video server no field
        // Also hiding away exception tags
        singletonInstance.setExceptionVisibility("hidden");

        if (checkMessage.includes("alarm") && checkMessage.includes("video")) {
            if (resultofExtraction == null) {
                throw "No digits found";
            }
            singletonInstance.setResultMessage("SUCCESS!!");
            if (checkMessage.startsWith("Alarm".toLowerCase())) {
                singletonInstance.setAlarmId(resultofExtraction[0]);
                singletonInstance.setVideoServerNo(resultofExtraction[1]);
            }
            else {
                singletonInstance.setAlarmId(resultofExtraction[1]);
                singletonInstance.setVideoServerNo(resultofExtraction[0]);
            }
        }
        else {
            throw "Text not found in string";
        }
    }
    catch (err)
    {
        // If all fails, then open exception tags and set appropriate message
        singletonInstance.setExceptionVisibility("visible");
        singletonInstance.setResultMessage("FAILED!!");

        if (err.startsWith("No digits")) {
            singletonInstance.setExceptionMessage("No digits found in the text field");
        }
        else if (err.startsWith("Text not found")) {
            singletonInstance.setExceptionMessage("Alarm and Video text not found in message box");
        }
        else {
            singletonInstance.setExceptionMessage(ex.Message);
        }
    }
}