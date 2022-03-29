
 <ul class="nav nav-tabs" dir="rtl">
      <?php $counter = 0 ;?>
      @foreach ($getclassesmain as $getclassesmaindata)
    <li class="@if ($counter == 0) active @endif"><a data-toggle="tab" href="#cat{{ $getclassesmaindata['id'] }}">{{ $getclassesmaindata["name"] }} </a></li>
    <?php $counter++;?>
    @endforeach
  </ul>
  <?php $counter = 0 ;?>
  <div class="tab-content text-right" style="padding-top: 20px">
                                @foreach ($getclassesmain as $key => $getclassesmaindata)
    <div id="cat{{ $getclassesmaindata['id'] }}" class="tab-pane fade in @if ($counter == 0) active @endif">
    
      <div class="clearfix"></div>
      @if (isset($getclassessub["tab".$getclassesmaindata['id']]))
          @foreach ($getclassessub["tab".$getclassesmaindata['id']] as $key => $getclassessubdate)
           <div class="page-info" style="margin-bottom: 10px;">
        <div class="auto-container">
        <?php if(\App\System::getCookies()=="ar"){ ?>
            <div class="inner-container clearfix text-right">
            <h4>{{ $getclassessubdate["name"] }} </h4>
            <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                <div class="inner-container clearfix text-left">
                <h4>{{ $getclassessubdate["second_name"] }} </h4>
                <?php } ?>
                
                
                </div>
                </div>
                </div>
                <div class="row">
				<?php
                    $getclassessubdate["eventsdata"] = collect($getclassessubdate["eventsdata"]);
                    
                    $getclassessubdate["eventsdata"] = $getclassessubdate["eventsdata"]->sortByDesc('edate');
                    
                    $getclassessubdate["eventsdata"]->values()->all();
                    
                    ?>
				
                @foreach ($getclassessubdate["eventsdata"] as $eventsdata)
<!--//Start backend to retrieve variables  -->

<?php

                        $eventid = $eventsdata["eventid"];
                        $eventtitle = $eventsdata["eheader"];
                         $eventdesc = $eventsdata["event"];

                         $eventtitlesecond = $eventsdata["second_eheader"];
                         $eventdescsecond = $eventsdata["second_event"];

                         $eventdate = $eventsdata["edate"];
                        
                         
                      $eventtimestamp = (string)$eventsdata["timestamp"];
                        $eventtimestamp = str_replace("-", "", $eventtimestamp);
                      
                        $eventtimestamp = str_replace(":", "",$eventtimestamp);
                        $eventimage = "https://softex-api-endpoint.azurewebsites.net/Cpanel/News/view/viewimage.php?imgtype=large&id=".$eventid;
                      
                       $eventimage = App\System::downloadfileV2($eventimage, env('APP_URL'), "events", "jpg", $eventtimestamp);
                       
                        ?>
<!--//End backend to retrieve variables  -->


            	
                <!--News Block-->
                <?php if(\App\System::getCookies()=="ar"){ ?>
                                <div class="news-block col-md-3 col-sm-6 col-xs-12 wow fadeIn pull-right">
                                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                                    <div class="news-block col-md-3 col-sm-6 col-xs-12 wow fadeIn pull-left">
                                    <?php } ?>

                                    <div class="inner-box">
                                        <div class="image">
                                            <a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}"><img src="{{ $eventimage }}" style="height: 150px;" alt="" /></a>
                                        </div>
                                        <div class="lower-box">
                                            <div class="post-info">{{ $eventdate }}</div>
                                            <?php if(\App\System::getCookies()=="ar"){ ?>
                                            <h3><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}" class="theme-btn read-more" style="margin-top: 10px">{{ $eventtitle }}</a></h3>
                                            
                                            <a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}" class="theme-btn read-more" style="margin-top: 10px; font-size: 14px">إقرأ المزيد<span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a>
                                            <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                                                <h3><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}" class="theme-btn read-more" style="margin-top: 10px">{{ $eventtitlesecond }}</a></h3>
                                            
                                                <a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}" class="theme-btn read-more" style="margin-top: 10px; font-size: 14px">Read More<span class="icon flaticon-right-arrow-1" style="margin-left: 10px;font-size: 20px;vertical-align: sub;"></span></a>
                                            <?php } ?>
                                            </div>
                                    </div>
                                </div>

@endforeach
                </div>
  

    @endforeach	
                @endif
                                <?php $counter++;?>
    
  </div>
  @endforeach
</div>
     

