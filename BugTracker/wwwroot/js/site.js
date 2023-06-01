// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('body').on("click", ".dropdown-menu", function (e) {
    $(this).parent().is(".open") && e.stopPropagation();
});

$("input[type='checkbox'].justone").change(function () {
    var a = $("input[type='checkbox'].justone");
    if (a.length == a.filter(":checked").length) {
        $('.selectall').prop('checked', true);
        $(".select-text").html(' Deselect');
    }
    else {
        $('.selectall').prop('checked', false);
        $(".select-text").html(' Select');
    }
    var total = $('input[name="options[]"]:checked').length;
    $(".dropdown-text").html('(' + total + ') Selected');
});