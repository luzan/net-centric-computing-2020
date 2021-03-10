﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function IsEmailAddress(txtEmailID) {
    var emlRegex = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
    var txtemail = document.getElementById(txtEmailID);
    if (mob.test(txtemail.value) == false) {
        alert("Please enter correct email.");
        txtemail.focus();
        return false;
    }
    return true;
}