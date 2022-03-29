<style>
    @media (min-width: 768px){
  .seven-cols .col-md-2,
  .seven-cols .col-sm-2,
  .seven-cols .col-lg-2  {
    width: 100%;
    *width: 100%;
  }
}

@media (min-width: 992px) {
  .seven-cols .col-md-2,
  .seven-cols .col-sm-2,
  .seven-cols .col-lg-2 {
    width: 14.285714285714285714285714285714%;
    *width: 14.285714285714285714285714285714%;
  }
}

/**
 *  The following is not really needed in this case
 *  Only to demonstrate the usage of @media for large screens
 */    
@media (min-width: 1200px) {
  .seven-cols .col-md-2,
  .seven-cols .col-sm-2,
  .seven-cols .col-lg-2 {
    width: 14.285714285714285714285714285714%;
    *width: 14.285714285714285714285714285714%;
  }
}
</style>
<div class="row d-flex flex-row-reverse seven-cols clearfix">
                            <!--big column-->
                           @foreach ($getmenu as $getmenudata)
                            <div class="big-column col-md-2 col-sm-12 col-xs-12 pull-left">
                         

                                    <!--Footer Column-->
                                    <div class="footer-column col-md-12 col-sm-12 col-xs-12">
                                        <div class="footer-widget links-widget">
                                        <?php if(\App\System::getCookies()=="ar"){ ?>
                                            <h2>{{ $getmenudata["name"] }}</h2>
                                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
       <h2>{{ $getmenudata["second_name"] }}</h2>
       <?php } ?>
                                            <div class="widget-content">
                                                <ul class="list">
                                                   
                                                  
                                                    @foreach ($getmenudata["linksdata"] as $gesubmenudata)
                                                      <?php
                                                    if($gesubmenudata["class"]=="32693"){
                                                        $linkfullurl = env('APP_URL')."aboutus/";
                                                    }
                                                    elseif($gesubmenudata["class"]=="32695"){
                                                        $linkfullurl = env('APP_URL')."car_conversion/";
                                                    }
                                                    elseif($gesubmenudata["class"]=="32696"){
                                                        $linkfullurl = env('APP_URL')."stations/";
                                                    }
                                                    elseif($gesubmenudata["class"]=="32697"){
                                                        $linkfullurl = env('APP_URL')."cylinder_test/";
                                                    }
                                                    elseif($gesubmenudata["class"]=="32698"){
                                                        $linkfullurl = env('APP_URL')."oil_distribution/";
                                                    }
                                                    elseif($gesubmenudata["class"]=="32699"){
                                                        $linkfullurl = env('APP_URL')."statistics/";
                                                    }
                                                     elseif($gesubmenudata["class"]=="32694"){
                                                        $linkfullurl = env('APP_URL')."hr/";
                                                    }
                                                    ?>
                                                    
                                                    <?php if(\App\System::getCookies()=="ar"){ ?>

<li> <a href="{{ $linkfullurl . $gesubmenudata["id"] }}">{{ $gesubmenudata["title"] }}</a> </li>
<?php } 

elseif(\App\System::getCookies()=="en"){ ?>
<li> <a href="{{ $linkfullurl . $gesubmenudata["id"] }}">{{ $gesubmenudata["second_title"] }}</a> </li>
<?php } ?>
                                                    
                                                    @endforeach
                                                </ul>
                                            </div>
                                        </div>
                                    </div>

                             
                            </div>
 @endforeach

                        </div>
