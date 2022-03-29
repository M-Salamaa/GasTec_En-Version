    <!-- Popular Posts -->
                        <div class="sidebar-widget popular-posts">
                        <?php if(\App\System::getCookies()=="ar"){ ?>
                            <div class="sidebar-title"><h2>آخر الأخبار</h2></div>
                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       <div class="sidebar-title"><h2>Latest News</h2></div>
        <?php } ?>

@foreach ($events->node as $eventsdata)

<!--//Start backend to retrieve variables  -->
<?php

                        $eventid = $eventsdata->attributes()->eventid;
                        $eventtitle = $eventsdata->attributes()->eheader;

                        $eventtitlesecond = $eventsdata->attributes()->second_eheader;
                        $eventdescsecond = $eventsdata->attributes()->second_event;

                         $eventdesc = $eventsdata->attributes()->event;
                         $eventdate = $eventsdata->attributes()->edate;
                        
                         
                      $eventtimestamp = (string)$eventsdata->attributes()->timestamp;
                        $eventtimestamp = str_replace("-", "", $eventtimestamp);
                      
                        $eventtimestamp = str_replace(":", "",$eventtimestamp);
                        $eventimage = "https://softex-api-endpoint.azurewebsites.net/Cpanel/News/view/viewimage.php?imgtype=large&id=".$eventid;
                        $eventimage = App\System::downloadfileV2($eventimage, env('APP_URL'), "events", "jpg", $eventtimestamp);

                       // $eventimage = App\System::downloadfile($eventimage, env('APP_URL'), "events", "jpg", $eventtimestamp);
                       if($addid==$eventid){
                           continue;
                       }
                        ?>
                        <?php if(\App\System::getCookies()=="ar"){ ?>
                            <article class="post">
                            	<figure class="post-thumb"><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}"><img src="{{ $eventimage }}" alt=""></a></figure>
                                <div class="text"><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}">{{ $eventtitle }}</a></div>
                                <div class="post-info">{{ $eventdate }}</div>
                            </article>
                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
                            <article class="post">
                            	<figure class="post-thumb"><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}"><img src="{{ $eventimage }}" alt=""></a></figure>
                                <div class="text"><a href="{{ env('APP_URL') }}newsfull/{{ $eventid }}">{{ $eventtitlesecond }}</a></div>
                                <div class="post-info">{{ $eventdate }}</div>
                            </article>
<?php } ?>

                         @endforeach   

                        </div>