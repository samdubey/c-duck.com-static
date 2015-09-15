function SendEmailSignUp() {
    var strError = "";
    strError += validateEmail(document.getElementById("newsletterEmailAddress"));

    if (strError != "") {
        alert(strError);
        return (false);
    }
    else {
        var Email = document.getElementById("newsletterEmailAddress");
        var webMethod = 'webservice/service.asmx/SendEmailNewsLetterSignUp';
        var parameters = "{'Email':'" + Email.value + "'}";
        $.ajax({
            type: "POST",
            url: webMethod,
            data: parameters,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (msg) {
                alert("Thank you for subscribing");
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(XMLHttpRequest.responseText + " -" + textStatus);
            }
        });
    }
}
function validateName(fld) {
    var error = "";
    if (fld.value.replace(/^\s*|\s*$/g, '') == "" || fld.value.length == 0) {
        error = "# Name can not be left blank.\n";
        fld.style.background = 'Yellow';
    }
    else {
        fld.style.background = '#EDF1F1';
    }
    return error;
}

function validateEmail(fld) {
    var error = "";
    if (!(/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(fld.value))) {
        error = "# Invalid E-mail Address! Please re-enter.\n";
        fld.style.background = 'Yellow';
    }
    else {
        fld.style.background = '#EDF1F1';
    }
    return error;
}

function validateMessage(fld) {
    var error = "";
    if (fld.value.replace(/^\s*|\s*$/g, '') == "" || fld.value.length == 0) {
        error = "# Message can not be left blank.\n";
        fld.style.background = 'Yellow';
    }
    else {
        fld.style.background = '#EDF1F1';
    }
    return error;
}
function SendEmailContactUs() {
    var strError = "";

    strError += validateName(document.getElementById("name"));
    strError += validateEmail(document.getElementById("email"));
    strError += validateMessage(document.getElementById("message"));

    if (strError != "") {
        alert(strError);
        return (false);
    }
    else {
        var Email = document.getElementById("email").value;
        var Name = document.getElementById("name").value;
        var Message = document.getElementById("message").value;
        var webMethod = 'webservice/service.asmx/SendEmailContactUs';
        var parameters = "{'Email':'" + Email + "','Name':'" + Name + "','Message':'" + Message + "'}";
        $.ajax({
            type: "POST",
            url: webMethod,
            data: parameters,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (msg) {
                alert("Thank you very much for contacting the C-Duck, we will get back to you shortly");
                resetform();
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(XMLHttpRequest.responseText + " -"
												+ textStatus);
            }
        });
    }
}
function resetform() {
    document.getElementById("email").value = '' ;
    document.getElementById("name").value='';
    document.getElementById("message").value='';
}