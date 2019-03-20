// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    // Gets the video src from the data-src on each button

    var $videoSrc;
    $('.video-link').click(function () {
        $videoSrc = $(this).data("src");
    });
    console.log($videoSrc);



    // when the modal is opened autoplay it  
    $('#myModal').on('shown.bs.modal', function (e) {

        // set the video src to autoplay and not to show related video. Youtube related video is like a box of chocolates... you never know what you're gonna get
        $("#video").attr('src', $videoSrc + "?rel=0&amp;showinfo=0&amp;modestbranding=1&amp;autoplay=1");
    })


    // stop playing the youtube video when I close the modal
    $('#myModal').on('hide.bs.modal', function (e) {
        // a poor man's stop video
        $("#video").attr('src', $videoSrc);
    })

    $("#video").attr('src', $videoSrc + "?autoplay=1&amp;modestbranding=1&amp;showinfo=0");

    $("img").on("click", function (event) {
        /*
        var x = event.pageX - this.offsetLeft;
        var y = event.pageY - this.offsetTop;
        */
        var $div = $(event.target);
        var offset = $div.offset();

        var x = event.clientX - offset.left;
        var y = event.clientY - offset.top;
        
        console.log("X Coordinate: " + x + " Y Coordinate: " + y);

    });



    // document ready  
});


