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

    $(".menu-item, .menu-subitem").hover(function () {
        $(this).css("font-weight", "bold");
    },
    function () {
        $(this).css("font-weight", "normal");
    }
    );

    $(".tooltip").hover(function () {
        var tooltipText = $(this).attr("tooltip-text");
        $(this).parent().append("<div style='opacity:0;' class='tooltip-wrapper'><div class='tooltip-inner'><p>" + tooltipText + "</p></div></div>");
        $(this).siblings(".tooltip-wrapper").animate({ "opacity": "1" }, "slow");
    },
    function () {
        $(this).siblings(".tooltip-wrapper").animate({
            opacity: '0'}, {
            duration: "slow",
            complete: function () {
                $(this).remove(); 
            }
        })
    }
    );
});
