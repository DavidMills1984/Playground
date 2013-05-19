﻿$(document).ready(function () {

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
        if ($(this).siblings(".tooltip-wrapper").length == 0) {
            var tooltipText = $(this).attr("tooltip-text");
            $(this).parent().append("<div style='opacity:0;' class='tooltip-wrapper'><div class='tooltip-inner'><p>" + tooltipText + "</p></div></div>");
            $(this).siblings(".tooltip-wrapper").animate({ "opacity": "1" }, "slow");
        }

    },
    function () {
        $(this).siblings(".tooltip-wrapper").animate({
            opacity: '0'
        }, {
            duration: "slow",
            complete: function () {
                $(this).remove();
            }
        })
    }
    );

    $(".hs-img").HeroSwitching();

});

$.fn.HeroSwitching = function () {

    var imageAmount = $(this).attr("hs-img-amt");
    HeroSwitch($(this), 1, imageAmount);
}

function HeroSwitch($image, currentImage, imageAmount) {

    //Amount of time taken to fade a Hero image in and out
    var fadeDelay = 2500;
    //Amount of time a Hero image is displayed for
    var switchDelay = 15000

    $image.delay(switchDelay).fadeToggle(fadeDelay, function () {
        currentImage++;
        if (currentImage > imageAmount) {
            currentImage = 1;
        }
        //Switch the hero image using css
        $image.css("background-image", "url('/Images/HeroScroller/hero-image-" + currentImage + ".png')");
        //Fade hero image back in then call this function to loop back around the process
        $image.fadeToggle(fadeDelay, function () { HeroSwitch($image, currentImage, imageAmount); });
    });

        
}
