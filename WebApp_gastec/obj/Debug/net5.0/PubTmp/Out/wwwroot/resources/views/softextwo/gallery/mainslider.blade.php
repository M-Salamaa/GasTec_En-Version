
        
        <section class="main-slider">
<div class="rev_slider_wrapper "  id="rev_slider_three_wrapper" data-source="gallery">
            <div class="rev_slider fullwidthabanner" id="rev_slider_three" data-version="5.4.1">
             
                <ul>
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

                                $gallerytitlesecond =
                                $gallerydata["second_title"];
                        $gallerydescsecond =
                                $gallerydata["second_description"];

                        $galleryimgsrc = env('PATH_DATA') . "Gallery/webservice/viewimage.php?&id=$galleryID&imgtype=large&Images&Clients_$galleryID";
                        
                        $galleryimgtimestamp = $gallerydata["timestamp"];
                       
                        $galleryimgtimestamp = str_replace("-", "", $galleryimgtimestamp);
                      
                        $galleryimgtimestamp = str_replace(":", "",$galleryimgtimestamp);
                     
                   $galleryimgsrc = App\System::downloadfileV2($galleryimgsrc, env('APP_URL'), "gallery", "jpg", $galleryimgtimestamp);
                 
                        ?>
<!--//end backend to retrieve variables  -->


                	
                    <li data-description="Slide Description" data-easein="default" data-easeout="default" data-fsmasterspeed="1500" data-fsslotamount="7" data-fstransition="parallaxhorizontal" data-hideafterloop="0" data-hideslideonmobile="off" data-index="rs-{{ $galleryID }}" data-masterspeed="default" data-param1="" data-param10="" data-param2="" data-param3="" data-param4="" data-param5="" data-param6="" data-param7="" data-param8="" data-param9="" data-rotate="0" data-saveperformance="off" data-slotamount="default" data-thumb="{{ $galleryimgsrc }}" data-title="Slide Title" data-transition="parallaxhorizontal">
                    <img alt="" class="rev-slidebg" data-bgfit="cover" data-bgparallax="10" data-bgposition="center center" data-bgrepeat="no-repeat" data-no-retina="" src="{{ $galleryimgsrc }}"> 
                    
                    <div class="tp-caption" 
                    data-paddingbottom="[0,0,0,0]"
                    data-paddingleft="[0,0,0,0]"
                    data-paddingright="[0,0,0,0]"
                    data-paddingtop="[0,0,0,0]"
                    data-responsive_offset="on"
                    data-type="text"
                    data-height="none"
                    data-width="['700','700','700','400']"
                    data-whitespace="normal"
                    data-hoffset="['15','15','15','15']"
                    data-voffset="['150','120','90','95']"
                    data-x="['center','center','center','center']"
                    data-y="['middle','middle','middle','middle']"
                    data-textalign="['center','center','center','center']"
                    data-frames='[{"from":"y:[-100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;","mask":"x:0px;y:0px;s:inherit;e:inherit;","speed":1500,"to":"o:1;","delay":1000,"ease":"Power3.easeInOut"},{"delay":"wait","speed":1000,"to":"auto:auto;","mask":"x:0;y:0;s:inherit;e:inherit;","ease":"Power3.easeInOut"}]'>
                    <?php if(\App\System::getCookies()=="ar"){ ?>
                            <h2>{{ $gallerytitle }} </h2>
                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
                            <h2>{{ $gallerytitlesecond }} </h2>
                            <?php } ?>
                    </div>
                    
                    <div class="tp-caption hidden-xs" 
                    data-paddingbottom="[0,0,0,0]"
                    data-paddingleft="[0,0,0,0]"
                    data-paddingright="[0,0,0,0]"
                    data-paddingtop="[0,0,0,0]"
                    data-responsive_offset="on"
                    data-type="text"
                    data-height="none"
                    data-width="['700','700','700','400']"
                    data-whitespace="normal"
                    data-hoffset="['15','15','15','15']"
                    data-voffset="['250','200','140','145']"
                    data-x="['center','center','center','center']"
                    data-y="['middle','middle','middle','middle']"
                    data-textalign="['center','center','center','center']"
                    data-frames='[{"from":"y:[100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;","mask":"x:0px;y:0px;s:inherit;e:inherit;","speed":1500,"to":"o:1;","delay":1000,"ease":"Power3.easeInOut"},{"delay":"wait","speed":1000,"to":"auto:auto;","mask":"x:0;y:0;s:inherit;e:inherit;","ease":"Power3.easeInOut"}]'>
                    <?php if(\App\System::getCookies()=="ar"){ ?>
                    <div class="text">{!! $gallerydesc !!}</div>
                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
       <div class="text">{!! $gallerydescsecond !!}</div>
       <?php } ?>
                    </div>
                    
                    
                    
                    </li>
 

@endforeach

</ul>
            </div>
        </div>
            </section>
 <script src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/js/main-slider-script.js"></script>