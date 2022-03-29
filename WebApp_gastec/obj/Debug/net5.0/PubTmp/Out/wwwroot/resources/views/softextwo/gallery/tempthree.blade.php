
 <div class="four-item-carousel owl-carousel owl-theme">
@foreach ($gallery as $gallerydata)

<!--//Start backend to retrieve variables  -->
<?php
$galleryID =
                                $gallerydata["id"];
                        $galleryurl =
                                $gallerydata["url"];
                        $gallerytitle =
                                $gallerydata["title"];
                        $gallerydesc =
								$gallerydata["description"];
								
						$gallerytitlesecond = $gallerydata["second_title"];
                        $gallerydescsecond = $gallerydata["second_description"];

                        $galleryimgsrc = env('PATH_DATA') . "Gallery/webservice/viewimage.php?&id=$galleryID&imgtype=large&Images&Clients_$galleryID";
                        $galleryimgtimestamp = $gallerydata["timestamp"];
                       
                        $galleryimgtimestamp = str_replace("-", "", $galleryimgtimestamp);
                      
                        $galleryimgtimestamp = str_replace(":", "",$galleryimgtimestamp);
                     
                   $galleryimgsrc = App\System::downloadfileV2($galleryimgsrc, env('APP_URL'), "gallery", "jpg", $galleryimgtimestamp);
                       
                        ?>
<!--//end backend to retrieve variables  -->
                          
            	
                <!--Services Block-->
                <div class="services-block-three">
                	<div class="inner-box">
                    	<div class="image">
                        	<a href="{{ $galleryurl }}"><img src="{{ $galleryimgsrc }}" alt="" /></a>
						</div>
						<?php if(\App\System::getCookies()=="ar"){ ?>
                        <div class="lower-content">
							<h3><a href="{{ $galleryurl }}">{{ $gallerytitle }}</a></h3>
							
                            <div class="text"><a href="{{ $galleryurl }}" class="theme-btn read-more" dir="rtl">إقرأ المزيد<span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a></div>
								
	</div>

	<?php } 
       
	   elseif(\App\System::getCookies()=="en"){ ?> 
	   <div class="lower-content">
							<h3><a href="{{ $galleryurl }}">{{ $gallerytitlesecond }}</a></h3>
							
                            <div class="text"><a href="{{ $galleryurl }}" class="theme-btn read-more">Read More <span class="icon flaticon-right-arrow-1" style="margin-left: 10px;font-size: 20px;vertical-align: sub;"></span></a></div>
								
	</div>
	   <?php } ?>				

                    </div>
                </div>
       

@endforeach
     </div>
<script>
    
    //Four Item Carousel
	if ($('.four-item-carousel').length) {
		$('.four-item-carousel').owlCarousel({
			loop:true,
			margin:30,
			nav:true,
			smartSpeed: 700,
			autoplay: 4000,
			navText: [ '<span class="fa fa-angle-left"></span>', '<span class="fa fa-angle-right"></span>' ],
			responsive:{
				0:{
					items:2
				},
                                300:{
					items:2
				},
				600:{
					items:2
				},
				800:{
					items:2
				},
				1024:{
					items:3
				},
				1200:{
					items:4
				}
			}
		});    		
	}
    </script>