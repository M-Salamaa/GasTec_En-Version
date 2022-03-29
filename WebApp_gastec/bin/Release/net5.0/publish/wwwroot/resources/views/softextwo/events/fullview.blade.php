@foreach ($event->node as $eventsdata)
  <?php

     $eventid = $eventsdata->attributes()->eventid;
                        $eventtitle = $eventsdata->attributes()->eheader;
                         $eventdesc = $eventsdata->attributes()->event;
                         $eventdesc=\App\System::HtmlImgCache($eventdesc);

                         $eventtitlesecond = $eventsdata->attributes()->second_eheader;
                         $eventdescsecond = $eventsdata->attributes()->second_event;
                         $eventdescsecond=\App\System::HtmlImgCache($eventdescsecond);

                         $eventdate = $eventsdata->attributes()->edate;
                         $eventclass = $eventsdata->attributes()->class;
                           $eventtimestamp = (string)$eventsdata->attributes()->timestamp;
                        $eventtimestamp = str_replace("-", "", $eventtimestamp);
                      
                        $eventtimestamp = str_replace(":", "",$eventtimestamp);
                        $eventimage = "https://softex-api-endpoint.azurewebsites.net/Cpanel/News/view/viewimage.php?imgtype=large&id=".$eventid;
                       $eventimage = App\System::downloadfileV2($eventimage, env('APP_URL'), "events", "jpg", $eventtimestamp);

                       
  ?>

<div class="blog-classic padding-right" style="padding-right:0;">
                    	<!--Large Image Posts-->
						<div class="large-image-posts">
                    
                            <!--News Block Three-->
                            <div class="news-block-three">
                                <div class="inner-box">
                                    <div class="image">
                                        <a href="#" alt="{{ $eventtitle }}" title="{{ $eventtitle }}"><img src="{{ $eventimage }}" alt=""></a>
                                    </div>
                                    <div class="lower-content">
                                    <?php if(\App\System::getCookies()=="ar"){ ?>
                                        <div class="lower-box">
                                            <p style="color: #999"><i class="fa fa-calendar"></i> {{ $eventdate }}</p>
                                            <h3><a href="#">{{ $eventtitle }}</a></h3>
                                            <p>{!! $eventdesc !!}</p>
                                           <a href="{{ env('APP_URL') }}allnews/{{ $eventclass }}" class="theme-btn read-more" style="float: left;direction: rtl;font-size: 18px;">عرض جميع الأخبار<span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a>
                                            
                                        </div>
                                        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
<div class="lower-box">
                                            <p style="color: #999"><i class="fa fa-calendar"></i> {{ $eventdate }}</p>
                                            <h3><a href="#">{{ $eventtitlesecond }}</a></h3>
                                            <p>{!! $eventdescsecond !!}</p>
                                           <a href="{{ env('APP_URL') }}allnews/{{ $eventclass }}" class="theme-btn read-more" style="float: left;direction: ltr;font-size: 18px;"><span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span>View all news</a>
                                            
                                        </div>
                                        <?php } ?>
                                    </div>
                                </div>
                            </div>
                            
                        </div>
                       
                    
                    </div>

@endforeach

  <?php
                            \App\System::getModule("sideevents",$eventclass."/".$eventid,"#sideevents","<div class='linear-background'></div>");
                            ?>