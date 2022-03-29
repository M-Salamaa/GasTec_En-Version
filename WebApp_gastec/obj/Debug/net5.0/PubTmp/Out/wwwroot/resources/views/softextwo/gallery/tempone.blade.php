
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
                        $galleryimgsrc = env('PATH_DATA') . "Gallery/webservice/viewimage.php?&id=$galleryID&imgtype=large&Images&Clients_$galleryID";
                        $galleryimgtimestamp = $gallerydata["timestamp"];
                       
                        $galleryimgtimestamp = str_replace("-", "", $galleryimgtimestamp);
                      
                        $galleryimgtimestamp = str_replace(":", "",$galleryimgtimestamp);
                     
                   $galleryimgsrc = App\System::downloadfileV2($galleryimgsrc, env('APP_URL'), "gallery", "jpg", $galleryimgtimestamp);
                       
                        ?>
<!--//end backend to retrieve variables  -->



                          
                        <div class="team-block col-md-3 col-sm-6 col-xs-12 pull-right">
                            	<div class="inner-box">
                                	<div class="image">
                                        <a href="<?=env('APP_URL')?>imagefull/{{ $galleryID }}"><img src="{{ $galleryimgsrc  }}" alt=""></a>
                                        
                                    </div>
                                    <div class="lower-box">
                                    	<h3><a href="<?=env('APP_URL')?>imagefull/{{ $galleryID }}" style="font-size:16px">{{ $gallerytitle }}</a></h3>
                                       <div style="font-size:14px">{!! $gallerydesc !!}</div>
                                    </div>
                                </div>
                            </div>

@endforeach