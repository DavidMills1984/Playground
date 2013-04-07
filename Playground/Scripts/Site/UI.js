$(document).ready(function () {

    $(".menu-item-wrapper").hover(function () {
        $item = $(this).find(">:first");
        $item.animate({ "margin-left": "25px" }, "slow");
        $item.siblings().slideToggle('slow');
    },
    function () {
        $item = $(this).find(">:first");
        $item.animate({ "margin-left": "5px" }, "slow");
        $item.siblings().slideToggle('slow');
    }
    );


});