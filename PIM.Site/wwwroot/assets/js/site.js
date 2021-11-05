jQuery(document).ready(function ($) {
    "use strict";

    $('#carousel-card').owlCarousel({
        loop: true,
        center: true,
        items: 3,
        margin: 0,
        autoplay: true,
        dots: false,
        autoplayTimeout: 8500,
        smartSpeed: 450,
        navigationText: ['<span class="fa-stack"><i class="fa fa-circle fa-stack-1x"></i><i class="fa fa-chevron-circle-left fa-stack-1x fa-inverse"></i></span>', '<span class="fa-stack"><i class="fa fa-circle fa-stack-1x"></i><i class="fa fa-chevron-circle-right fa-stack-1x fa-inverse"></i></span>'],
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 2
            },
            1170: {
                items:3
            }
        }
    })
})


/*Troca de item ativo menu*/
$(document).ready(function () {
    $(".nav-item").on("click", function (event) {
        var clickedItem = $(this);
        $(".nav-item").each(function () {
            $(this).removeClass("active");
        });
        clickedItem.addClass("active");
    });
});