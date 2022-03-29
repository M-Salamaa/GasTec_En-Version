<div class="row clearfix">
    <div class="page-info">
        <div class="auto-container">
            <div class="inner-container clearfix text-right">
                <h4>{{\App\System::getFinalText('search-pages')}}</h4>

            </div>
        </div>
    </div>

    <div class="team-column col-md-12 col-sm-12 col-xs-12" style="margin-top: 30px">
        <div class="inner-column">
            <div class="row clearfix">                              
                @foreach ($gethtmlresults as $gethtmlresultdata)
                <?php
                $linkclass = $gethtmlresultdata["class"];
                $linkid = $gethtmlresultdata["id"];
                $linktitle = $gethtmlresultdata["title"];
                if ($linkclass == "32693") {
                    $linkfullurl = env('APP_URL') . "aboutus/";
                } elseif ($linkclass == "32695") {
                    $linkfullurl = env('APP_URL') . "car_conversion/";
                } elseif ($linkclass == "32696") {
                    $linkfullurl = env('APP_URL') . "stations/";
                } elseif ($linkclass == "32697") {
                    $linkfullurl = env('APP_URL') . "cylinder_test/";
                } elseif ($linkclass == "32698") {
                    $linkfullurl = env('APP_URL') . "oil_distribution/";
                } elseif ($linkclass == "32699") {
                    $linkfullurl = env('APP_URL') . "statistics/";
                }
                ?>
                <div style="margin-bottom: 10px" class="text-right"> <a href="{{ $linkfullurl.$linkid }}" target="blank" data-caption="{{ $linktitle }}">{{ $linktitle }}</a></div>               
                @endforeach
            </div>
        </div>
    </div>

</div>

<div class="row clearfix">
    <div class="page-info">
        <div class="auto-container">
            <div class="inner-container clearfix text-right">
                <h4>{{\App\System::getFinalText('search-news')}}</h4>

            </div>
        </div>
    </div>

    <div class="team-column col-md-12 col-sm-12 col-xs-12" style="margin-top: 30px">
        <div class="inner-column">
            <div class="row clearfix">
@foreach ($geteventsreults as $geteventsresultsdata)
<?php
$eventid = $geteventsresultsdata["eventid"];
$eventtitle = $geteventsresultsdata["eheader"];
?>
                <div style="margin-bottom: 10px" class="text-right"> <a href="{{ env('APP_URL')."newsfull/".$eventid }}" target="blank" data-caption="{{ $eventtitle }}">{{ $eventtitle }} </a></div>
@endforeach
            </div>
        </div>
    </div>

</div>

<div class="row clearfix">
    <div class="page-info">
        <div class="auto-container">
            <div class="inner-container clearfix text-right">
                <h4>{{\App\System::getFinalText('search-videos')}}</h4>
            </div>
        </div>
    </div>

    <div class="team-column col-md-12 col-sm-12 col-xs-12" style="margin-top: 30px">
        <div class="inner-column">
            <div class="row clearfix">
@if(isset($getvideosresults["node"]) && is_array($xmlGeteventsClasses["node"]))
    @foreach ($getvideosresults["node"] as $getvideosresultsdata)
        <?php
        if(count($getvideosresults["node"])>1){
            $getvideodaatparm = $getvideosresultsdata["@attributes"];
        }
        else{
            $getvideodaatparm = $getvideosresultsdata;
        }
        $videoid = $getvideodaatparm["id"];
        $videotitle = $getvideodaatparm["title"];
        $videourl = $getvideodaatparm["link"];
        ?>
        <div style="margin-bottom: 10px" class="text-right"> <a href="{{ $videourl }}" class="lightbox-image overlay-box" data-caption="{{ $videotitle }}">{{ $videotitle }}</a></div>
    @endforeach
@endif
            </div>
        </div>
    </div>
 
</div>

<script>
    //LightBox / Fancybox
	if($('.lightbox-image').length) {
		$('.lightbox-image').fancybox({
			openEffect  : 'fade',
			closeEffect : 'fade',
			helpers : {
				media : {}
			}
		});
	}
    </script>