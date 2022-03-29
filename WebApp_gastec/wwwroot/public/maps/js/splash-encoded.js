(function ($) {
    "use strict";

    $(window).load(function(){
        // Animations Init // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        if ($().appear) {
            if (window.screen.width < 998) {
                $("body").removeClass("cssAnimate");
            } else {
                $('.cssAnimate .animated').appear(function () {
                    var $this = $(this);

                    $this.each(function () {
                        if ($this.data('time') != undefined) {
                            setTimeout(function () {
                                $this.addClass('activate');
                                $this.addClass($this.data('fx'));
                            }, $this.data('time'));
                        } else {
                            $this.addClass('activate');
                            $this.addClass($this.data('fx'));
                        }
                    });
                }, {accX: 50, accY: -350});
            }
        }
    });

    $(document).ready(function () {

        $("[data-toggle='tooltip']").tooltip();

        /* ======================= */
        /* ==== TO TOP BUTTON ==== */


        $('#toTop').click(function () {
            $("body,html").animate({scrollTop: 0}, 600);
            return false;
        });

        /* ========================== */
        /* ==== SCROLL TO SECTION ==== */

        $('.ct-js-btnScroll[href^="#"]').click( function (e) {
            e.preventDefault();

            var target = this.hash, $target = $(target);

            $('html, body').stop().animate({
                'scrollTop': $target.offset().top
            }, 900, 'swing', function () {
                window.location.hash = target;
            });
        });

        $(window).scroll(function () {
            if ($(this).scrollTop() != 0) {
                $("#toTop").fadeIn(300);
            } else {
                $("#toTop").fadeOut(250);
            }
        });



        $(".firstExample").ShopLocator({
            pluginStyle: "cosmic",
            paginationStyle: 2,
            infoBubble: {
                visible: true,
                arrowPosition: 50,
                minHeight: 112,
                maxHeight: null,
                minWidth: 170,
                maxWidth: 250
            },
            markersIcon: "public/src/style/cosmic/images/marker.png",
            map:{
                mapStyle: [{"featureType":"administrative","elementType":"labels.text.fill","stylers":[{"color":"#7d8d97"}]},{"featureType":"landscape","elementType":"all","stylers":[{"color":"#f2f2f2"}]},{"featureType":"landscape","elementType":"geometry.fill","stylers":[{"color":"#f2f5f6"}]},{"featureType":"poi","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"poi.attraction","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"poi.park","elementType":"geometry.fill","stylers":[{"color":"#e6f3d6"},{"visibility":"off"}]},{"featureType":"road","elementType":"all","stylers":[{"saturation":-100},{"lightness":45},{"visibility":"off"}]},{"featureType":"road.highway","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"road.highway","elementType":"geometry.fill","stylers":[{"color":"#f4d2c5"},{"visibility":"simplified"}]},{"featureType":"road.highway","elementType":"labels.text","stylers":[{"color":"#4e4e4e"}]},{"featureType":"road.arterial","elementType":"geometry.fill","stylers":[{"color":"#f4f4f4"}]},{"featureType":"road.arterial","elementType":"labels.text.fill","stylers":[{"color":"#787878"}]},{"featureType":"road.arterial","elementType":"labels.icon","stylers":[{"visibility":"off"}]},{"featureType":"transit","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"water","elementType":"all","stylers":[{"visibility":"on"},{"hue":"#ff0000"},{"saturation":"-100"},{"lightness":"45"}]},{"featureType":"water","elementType":"geometry.fill","stylers":[{"color":"#cddbe2"}]}]
            },
            marker:{
                animation: google.maps.Animation.DROP
            },
            cluster:{
                enable: true,
                gridSize: 50,
                style:{
                    textColor: '#4757a3',
                    textSize: 18,
                    heightSM: 42,
                    widthSM: 42,
                    heightMD: 56,
                    widthMD: 56,
                    heightBIG: 75,
                    widthBIG: 75,
                    iconSmall: "public/src/style/cosmic/images/clusterSmall.png",
                    iconMedium: "public/src/style/cosmic/images/clusterMedium.png",
                    iconBig: "public/src/style/cosmic/images/clusterBig.png"
                }
            },
            sidebar: {
                visible: true,
                selectSection:{
                    visible: true
                },
                searchBox: {
                    visible: true,
                    search: true
                },
                results:{
                    pageSize: 8
                }
            }
        });

        $(".secondExample").ShopLocator({
            infoBubble:{
                visible: true
            },
            map:{
                allMarkersInViewport: false,
                scrollwheel: false
            },
            marker:{
                latlng: [52.2296760, 21.0122290],
                title: "CreateIT",
                street: "ul. Narbutta 22/15",
                zip: "+48 22 378 3 379",
                city: "Warszawa"
            }
        });

        $(".thirdExample").ShopLocator({
            pluginStyle: "cosmic",
            json: "src/json/markers.json",
            infoBubble: {
                visible: true,
                arrowPosition: 50,
                minHeight: 112,
                maxHeight: null,
                minWidth: 170,
                maxWidth: 250
            },
            markersIcon: "public/src/style/cosmic/images/marker.png",
            cluster:{
                enable: true,
                gridSize: 50,
                style:{
                    textColor: '#4757a3',
                    textSize: 18,
                    heightSM: 42,
                    widthSM: 42,
                    heightMD: 56,
                    widthMD: 56,
                    heightBIG: 75,
                    widthBIG: 75,
                    iconSmall: "public/src/style/cosmic/images/clusterSmall.png",
                    iconMedium: "public/src/style/cosmic/images/clusterMedium.png",
                    iconBig: "public/src/style/cosmic/images/clusterBig.png"
                }
            }
        });

        $(".fourthExample").ShopLocator({
            pluginStyle: "cosmic",
            paginationStyle: 2,
            infoBubble: {
                visible: true,
                arrowPosition: 50,
                minHeight: 112,
                maxHeight: null,
                minWidth: 170,
                maxWidth: 250
            },
            markersIcon: "public/src/style/cosmic/images/marker.png",
            map:{
                scrollwheel: false,
                mapStyle: [{"featureType":"administrative","elementType":"labels.text.fill","stylers":[{"color":"#7d8d97"}]},{"featureType":"landscape","elementType":"all","stylers":[{"color":"#f2f2f2"}]},{"featureType":"landscape","elementType":"geometry.fill","stylers":[{"color":"#f2f5f6"}]},{"featureType":"poi","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"poi.attraction","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"poi.park","elementType":"geometry.fill","stylers":[{"color":"#e6f3d6"},{"visibility":"off"}]},{"featureType":"road","elementType":"all","stylers":[{"saturation":-100},{"lightness":45},{"visibility":"off"}]},{"featureType":"road.highway","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"road.highway","elementType":"geometry.fill","stylers":[{"color":"#f4d2c5"},{"visibility":"simplified"}]},{"featureType":"road.highway","elementType":"labels.text","stylers":[{"color":"#4e4e4e"}]},{"featureType":"road.arterial","elementType":"geometry.fill","stylers":[{"color":"#f4f4f4"}]},{"featureType":"road.arterial","elementType":"labels.text.fill","stylers":[{"color":"#787878"}]},{"featureType":"road.arterial","elementType":"labels.icon","stylers":[{"visibility":"off"}]},{"featureType":"transit","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"water","elementType":"all","stylers":[{"visibility":"on"},{"hue":"#ff0000"},{"saturation":"-100"},{"lightness":"45"}]},{"featureType":"water","elementType":"geometry.fill","stylers":[{"color":"#cddbe2"}]}]
            },
            cluster:{
                enable: true,
                gridSize: 50,
                style:{
                    textColor: '#4757a3',
                    textSize: 18,
                    heightSM: 42,
                    widthSM: 42,
                    heightMD: 56,
                    widthMD: 56,
                    heightBIG: 75,
                    widthBIG: 75,
                    iconSmall: "public/src/style/cosmic/images/clusterSmall.png",
                    iconMedium: "public/src/style/cosmic/images/clusterMedium.png",
                    iconBig: "public/src/style/cosmic/images/clusterBig.png"
                }
            },
            sidebar: {
                visible: true,
                selectSection:{
                    visible: true
                },
                searchBox: {
                    visible: true,
                    search: true
                },
                results:{
                    pageSize: 8
                }
            }
        });

        $(".seventhStyle").ShopLocator({
            pluginStyle: "metro",
            paginationStyle: 1,
            infoBubble: {
                visible: true,
                backgroundColor: 'transparent',
                arrowSize: 0,
                arrowPosition: 50,
                minHeight: 127,
                maxHeight: 135,
                minWidth: 170,
                maxWidth: 250,
                hideCloseButton: false
            },
            map:{
                mapStyle: [{"featureType":"landscape","stylers":[{"saturation":-100},{"lightness":65},{"visibility":"on"}]},{"featureType":"poi","stylers":[{"saturation":-100},{"lightness":51},{"visibility":"simplified"}]},{"featureType":"road.highway","stylers":[{"saturation":-100},{"visibility":"simplified"}]},{"featureType":"road.arterial","stylers":[{"saturation":-100},{"lightness":30},{"visibility":"on"}]},{"featureType":"road.local","stylers":[{"saturation":-100},{"lightness":40},{"visibility":"on"}]},{"featureType":"transit","stylers":[{"saturation":-100},{"visibility":"simplified"}]},{"featureType":"administrative.province","stylers":[{"visibility":"off"}]},{"featureType":"water","elementType":"labels","stylers":[{"visibility":"on"},{"lightness":-25},{"saturation":-100}]},{"featureType":"water","elementType":"geometry","stylers":[{"hue":"#ffff00"},{"lightness":-25},{"saturation":-97}]}]
            },
            markersIcon: "public/src/style/metro/images/marker.png",
            cluster:{
                enable: true,
                gridSize: 60,
                style:{
                    textColor: '#79aacf',
                    textSize: 18,
                    heightSM: 54,
                    widthSM: 54,
                    heightMD: 64,
                    widthMD: 64,
                    heightBIG: 74,
                    widthBIG: 74,
                    iconSmall: "public/src/style/metro/images/clusterSmall.png",
                    iconMedium: "public/src/style/metro/images/clusterMedium.png",
                    iconBig: "public/src/style/metro/images/clusterBig.png"
                }
            },
            sidebar: {
                visible: true,
                selectSection:{
                    visible: true
                },
                searchBox: {
                    visible: true,
                    search: true
                },
                results:{
                    pageSize: 8,
                    paginationItems: 5
                }
            }
        });

        $(".default").ShopLocator({
            pluginStyle: "default",
            paginationStyle: 1,
            infoBubble: {
                visible: true,
                borderRadius: 0,
                backgroundColor: '#fff',
                arrowPosition: 50,
                minHeight: 119,
                maxHeight: 135,
                minWidth: 170,
                maxWidth: 250,
                offsetTop: 8
            },
            cluster:{
                enable: true,
                gridSize: 60
            },
            sidebar: {
                visible: true,
                selectSection:{
                    visible: true
                },
                searchBox: {
                    visible: true,
                    search: true
                },
                results:{
                    pageSize: 8,
                    paginationItems: 5
                }
            }
        });
    });

}(jQuery));




(function(){
    "use strict";

    var featurewidth = 203;

    $('.ct-featureButton').on('click', function(e){
        e.preventDefault();

        var $dropdowncontainer = $('.ct-dropdown-container');

        $(window).on('load resize', function(){
            if ($(window).width() < 480){
                featurewidth = 130;
            }
        })  ;

        if ($($dropdowncontainer).hasClass('active')){
            $($dropdowncontainer).removeClass('active').animate({width: '130' + 'px'}, 300).animate({height: '50' + 'px'}, 150);
        }
        else{
            $($dropdowncontainer).addClass('active').animate({width: featurewidth + 'px'}, 200).animate({height: '338' + 'px'}, 300);
        }

        return false;
    });
}(jQuery));