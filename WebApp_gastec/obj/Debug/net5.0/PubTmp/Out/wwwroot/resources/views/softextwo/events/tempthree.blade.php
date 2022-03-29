
          
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


            	
                <!--News Block-->
                                <div class="news-block col-md-4 col-sm-6 col-xs-12 wow fadeIn pull-right">
                                    <div class="inner-box">
                                        <div class="image">
                                            <a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}"><img src="{{ $eventimage }}" alt="" /></a>
                                        </div>
                                        <?php if(\App\System::getCookies()=="ar"){ ?>
                                        <div class="lower-box">
                                            <div class="post-info">{{ $eventdate }}</div>
                                            <h3><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}">{{ $eventtitle }}</a></h3>
                                          
                                            <a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}" class="theme-btn read-more">إقرأ المزيد<span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a>
                                            
                                        </div>
                                        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
      <div class="lower-box">
                                            <div class="post-info">{{ $eventdate }}</div>
                                            <h3><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}">{{ $eventtitlesecond }}</a></h3>
                                          
                                            <a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}" class="theme-btn read-more">Read More <span class="icon flaticon-right-arrow-1" style="margin-left: 10px;font-size: 20px;vertical-align: sub;"></span></a>
                                            
                                        </div>
       <?php } ?>
                                    </div>
                                </div>

@endforeach
