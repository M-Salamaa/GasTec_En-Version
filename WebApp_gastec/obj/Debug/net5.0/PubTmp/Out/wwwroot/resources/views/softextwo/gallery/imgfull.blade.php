<?php

$galleryID =
        
                                $gallerydata["id"];
                        $galleryurl =
                                $gallerydata["url"];
                        $gallerytitle =
                                $gallerydata["title"];
                                $gallerytitlesecond =
                                $gallerydata["second_title"];
                        $gallerydesc =
                                $gallerydata["description"];
                                $gallerydescsecond =
                                $gallerydata["second_description"];
                        $galleryimgsrc = env('PATH_DATA') . "Gallery/webservice/viewimage.php?&id=$galleryID&imgtype=large&Images&Clients_$galleryID";
                        $galleryimgtimestamp = $gallerydata["timestamp"];
                       
                        $galleryimgtimestamp = str_replace("-", "", $galleryimgtimestamp);
                      
                        $galleryimgtimestamp = str_replace(":", "",$galleryimgtimestamp);
                     
                   $galleryimgsrc = App\System::downloadfileV2($galleryimgsrc, env('APP_URL'), "gallery", "jpg", $galleryimgtimestamp);
                       
                        ?>
<div class="content-side col-lg-7 col-md-7 col-sm-12 col-xs-12">
    
<?php if(\App\System::getCookies()=="ar"){ ?>
        <div class="services-single" dir="rtl">

        <div class="sidebar-title"><h2>{{ $gallerytitle }}</h2></div>
                    
                    <div class="inner-box">
{!! $gallerydesc !!}
</div>
</div>

</div>
                <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       <div class="services-single" dir="ltr">
       <div class="sidebar-title"><h2>{{ $gallerytitlesecond }}</h2></div>
                    
                    <div class="inner-box">
{!! $gallerydescsecond !!}
</div>
</div>

</div>
       <?php } ?>

                       
            	<div class="sidebar-side col-lg-5 col-md-5 col-sm-12 col-xs-12 pull-right text-right">
                   <img src="{{ $galleryimgsrc }}" alt="">
               </div>