            	 <div class="three-item-carousel owl-carousel owl-theme">
  
                
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

                <div class="services-block-two wow slideInUp" data-wow-delay=".30s">
                    <div class="inner-box">
                        <div class="image">
                            <img src="{{ $eventimage }}" alt="" />
                            <div class="content-overlay">
                                <div class="overlay-inner">
                                    <div class="content-box">
                                    <?php if(\App\System::getCookies()=="ar"){ ?>
                                       <div class="blockdate"> {{ $eventdate }} &nbsp;<span class="icon flaticon-calendar"></span></div>
                                      
                                       <h4><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}">{{ $eventtitle }}</a></h4>
                                        
                                        <a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}" class="detail">اقرأ المزيد</a>
                                        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 

<div class="blockdate"><span class="icon flaticon-calendar"></span>  &nbsp;{{ $eventdate }}</div>
                                      
                                      <h4><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}">{{ $eventtitlesecond }}</a></h4>
                                       
                                       <a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}" class="detail">View More</a>

       <?php } ?>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

@endforeach

 </div>
                
<script>
    if ($('.three-item-carousel').length) {
       
		$('.three-item-carousel').owlCarousel({
			loop:true,
			margin:30,
			nav:true,
			smartSpeed: 700,
			autoplay: 4000,
			navText: [ '<span class="fa fa-angle-left"></span>', '<span class="fa fa-angle-right"></span>' ],
			responsive:{
				0:{
					items:1
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
					items:3
				}
			}
		});    		
	}
    </script>