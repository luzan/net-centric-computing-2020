// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function IsEmailAddress(email) {
    //var emlRegex = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;

    atpos = email.indexOf("@");
    dotpos = email.indexOf(".");
    if (atpos < 1 || (dotpos - atpos < 2)) {
        return false;
    }

    return true;
}