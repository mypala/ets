// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $(".iconDetail")
        .mouseover(function () {
            $(this).children("i").removeClass("bi-person");
            $(this).children("i").addClass("bi-person-fill");
        })
        .mouseout(function () {
            $(this).children("i").removeClass("bi-person-fill");
            $(this).children("i").addClass("bi-person");
        });

    $(".iconNew")
        .mouseover(function () {
            $(this).children("i").removeClass("bi-person-plus");
            $(this).children("i").addClass("bi-person-plus-fill");
        })
        .mouseout(function () {
            $(this).children("i").removeClass("bi-person-plus-fill");
            $(this).children("i").addClass("bi-person-plus");
        });

    $(".iconBack")
        .mouseover(function () {
            $(this).children("i").removeClass("bi-arrow-left-circle");
            $(this).children("i").addClass("bi-arrow-left-circle-fill");
        })
        .mouseout(function () {
            $(this).children("i").removeClass("bi-arrow-left-circle-fill");
            $(this).children("i").addClass("bi-arrow-left-circle");
        });
});

/*
    <div class="toast" role="alert" aria-live="assertive" aria-atomic="true">
        <div class="toast-header">
            <img src="..." class="rounded mr-2" alt="...">
                <strong class="mr-auto">Bootstrap</strong>
                <small class="text-muted">just now</small>
                <button type="button" class="ml-2 mb-1 close" data-dismiss="toast" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
      </div>
            <div class="toast-body">
                See? Just like this.
      </div>
    </div>
*/

function showAlert(message, type, closeDelay) {

    var $cont = $("#alerts-container");

    if ($cont.length == 0) {
        // alerts-container does not exist, create it
        $cont = $('<div id="alerts-container">')
            .css({
                position: "fixed"
                , width: "50%"
                , left: "25%"
                , top: "10%"
            })
            .appendTo($("body"));
    }

    // default to alert-info; other options include success, warning, danger
    type = type || "info";

    // create the alert div
    var alert = $('<div>')
        .addClass("fade in show alert alert-" + type)
        .append(
            $('<button type="button" class="close" data-dismiss="alert">')
                .append("&times;")
        )
        .append(message);

    // add the alert div to top of alerts-container, use append() to add to bottom
    $cont.prepend(alert);

    // if closeDelay was passed - set a timeout to close the alert
    //if (closeDelay)
    //    window.setTimeout(function () { alert.alert("close") }, closeDelay);
}