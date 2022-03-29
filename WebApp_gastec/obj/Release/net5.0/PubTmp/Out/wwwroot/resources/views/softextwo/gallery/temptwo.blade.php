 <!--Tabs Side-->
			<div>
  <ul class="nav nav-tabs" dir="rtl">
      <?php $counter = 0 ;?>
      @foreach ($galleryclassesmain as $galleryclassesdata)
    <li class="@if ($counter == 0) active @endif"><a data-toggle="tab" href="#cat{{ $galleryclassesdata['id'] }}">{{ $galleryclassesdata["name"] }} </a></li>
    <?php $counter++;?>
    @endforeach
  </ul>
 <?php $counter = 0 ;?>
                            <div class="tab-content text-right" style="padding-top: 20px">
                                @foreach ($galleryclassesmain as $key => $galleryclassesdata)
    <div id="cat{{ $galleryclassesdata['id'] }}" class="tab-pane fade in @if ($counter == 0) active @endif">
    
        
      <div class="clearfix">
          @if (isset($getclassessub["tab".$galleryclassesdata['id']]))
          @foreach ($getclassessub["tab".$galleryclassesdata['id']] as $key => $galleryclassessubdata)
           <div class="page-info">
        <div class="auto-container">
        <?php if(\App\System::getCookies()=="ar"){ ?>
            <div class="inner-container clearfix text-right">
            <h4>{{ $galleryclassessubdata["name"] }} </h4>
            <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                <div class="inner-container clearfix text-left">
                <h4>{{ $galleryclassessubdata["second_name"] }} </h4>
                <?php } ?>
                
                <!-- <a href="#" class="theme-btn read-more" style="float: left;direction: rtl;font-size: 18px;"> عرض المزيد <span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a> -->
            </div>
        </div>
    </div>
          <div class="team-column col-md-12 col-sm-12 col-xs-12" style="margin-top: 30px">
                	<div class="inner-column">
                    	<div class="row clearfix">

@foreach ($galleryclassessubdata["images"] as $gallerydata)

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
                        $galleryimgsrc = env('PATH_DATA') . "Gallery/webservice/viewimage.php?&id=$galleryID&imgtype=large&Images&Clients_$galleryID";
                        $galleryimgtimestamp = $gallerydata["timestamp"];
                       
                        $galleryimgtimestamp = str_replace("-", "", $galleryimgtimestamp);
                      
                        $galleryimgtimestamp = str_replace(":", "",$galleryimgtimestamp);
                     
                   $galleryimgsrc = App\System::downloadfileV2($galleryimgsrc, env('APP_URL'), "gallery", "jpg", $galleryimgtimestamp);
                       
                        ?>
<!--//end backend to retrieve variables  -->



                          
                  
                        
                            <!--Team Block-->
                            <div class="shop-item col-md-3 col-sm-6 col-xs-12 pull-right">
                            	<div class="inner-box">
                                	<div class="image">
                                    	
                                        <a href="{{ $galleryimgsrc }}" data-fancybox="images"  data-caption="This image has a caption"><img src="{{ $galleryimgsrc }}" alt=""></a>
                            
                                    </div>
                                    
                                </div>
                            </div>
                            
                            
                            
                   

@endforeach
     </div>
                    </div>
                </div>
             @endforeach	
                @endif
                
            </div>

    </div>
                                <?php $counter++;?>
    @endforeach
  </div>
</div>
                     <!--End Tabs Side-->

