
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

<img src="{{ $galleryimgsrc }}" class="eni-img img-opa" alt="">


@endforeach