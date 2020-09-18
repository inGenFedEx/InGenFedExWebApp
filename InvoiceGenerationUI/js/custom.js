function InitializeRequest() {
    $('.loading').show();
}

function EndRequest() {
    $('.loading').hide();
}

function validate(validationGroup)
{
    var IsValid = Page_ClientValidate(validationGroup);

    if (IsValid) {
        InitializeRequest();
    }
    return IsValid;
}

function showhidemessage(obj) {
    alert(obj);
    $(obj).fadeTo(2000, 500).slideUp(500, function () {
        $(obj).slideUp(500);
    });
}


function fncEnterClick(evt, buttonId) {
    var event = evt ? evt : window.event;
    var bt = document.getElementById(buttonId);
    if (bt) {
        var code = event.which || event.keyCode || event.charCode;
        if (code == 13) {
            document.getElementById(buttonId).click();
            return false;
        }
    }
}

function BindNavBarActive(id) {
    if ($(id) != null && $(id) != 'undefined') {
        if ($(location).attr('pathname').toLowerCase() != "/") {
            $(id + " a").removeClass("active");
            $(id + " a").each(function (idx, li) {
                if ($(this) != null && $(this) != 'undefined' && $(this).attr('href') != null && $(this).attr('href') != 'undefined' ) {
                    if ($(location).attr('pathname').toLowerCase().indexOf($(this).attr('href').toLowerCase()) > -1) {
                        $(this).addClass("active");
                    }
                }
            });
        }
    }
}

function fncClosePopup(id) {
    $('' + id).modal('hide');
    $('body').removeClass('modal-open');
    $('.modal-backdrop').remove();
}

function fncOpenPopup(id) {
    $('' + id).modal('show');
}