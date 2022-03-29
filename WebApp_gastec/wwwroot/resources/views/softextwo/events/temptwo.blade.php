
            	  <div class="single-item-carousel owl-carousel owl-theme">
  
                
@foreach ($events->node as $eventsdata)
<!--//Start backend to retrieve variables  -->
<?php


                        $eventid = $eventsdata->attributes()->eventid;
                        $eventtitle = $eventsdata->attributes()->eheader;
						 $eventdesc = $eventsdata->attributes()->event;
						 
						 $eventtitlesecond = $eventsdata->attributes()->second_eheader;
                         $eventdescsecond = $eventsdata->attributes()->second_event;

                         $eventdate = $eventsdata->attributes()->edate;
                        
                         
                      $eventtimestamp = (string)$eventsdata->attributes()->timestamp;
                        $eventtimestamp = str_replace("-", "", $eventtimestamp);
                      
                        $eventtimestamp = str_replace(":", "",$eventtimestamp);
                        $eventimage = "https://softex-api-endpoint.azurewebsites.net/Cpanel/News/view/viewimage.php?imgtype=large&id=".$eventid;
                        
                       $eventimage = App\System::downloadfileV2($eventimage, env('APP_URL'), "events", "jpg", $eventtimestamp);
                       
                        ?>
<!--//End backend to retrieve variables  -->

                
            	
                <div class="testimonial-block">
                	<div class="inner-box">
                    	
                        <div class="upper-box">
                        	<div class="image">
                            	<img src="{{ $eventimage }}" alt="" />
                            </div>
                           
						</div>
						<?php if(\App\System::getCookies()=="ar"){ ?>
						<div class="text"><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}">{{ $eventtitle }}</a></div>
						<?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
						<div class="text"><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}">{{ $eventtitlesecond }}</a></div>
						<?php } ?>
                    </div>
                </div>

@endforeach

 </div>
                
<script>
    if ($('.single-item-carousel').length) {
		$('.single-item-carousel').owlCarousel({
			loop:true,
			margin:0,
			nav:true,
			smartSpeed: 500,
			autoplay: true,
			navText: [ '<span class="fa fa-angle-left"></span>', '<span class="fa fa-angle-right"></span>' ],
			responsive:{
				0:{
					items:1
				},
				600:{
					items:1
				},
				800:{
					items:1
				},
				1024:{
					items:1
				},
				1200:{
					items:1
				}
			}
		});    		
	}
    </script>