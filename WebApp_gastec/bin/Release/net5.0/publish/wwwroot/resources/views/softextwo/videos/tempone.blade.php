<div class="large-image-posts">

    @foreach ($videos->node as $videovalues)
    
                            <!--News Block Three-->
                            <div class="news-block-three col-md-6 col-sm-12 col-xs-12 pull-right">
                                <div class="inner-box">
                                    <div class="video-box">
                                    <div class="image">
                                        <img src="https://softex-api-endpoint.azurewebsites.net/Cpanel/Videos/viewimage.php?id={{ $videovalues->attributes()->id }}&imageprev=thumprev" alt="" />
                                         <a href="{{$videovalues->attributes()->link }}" class="lightbox-image overlay-box"><span class="flaticon-play-button-2"></span></a>
                                    </div>
                                        </div>
                                    <div class="lower-content">
                                        
                                        <div class="lower-box" style="height: 40px;">
                                            
                                            <h3>{{$videovalues->attributes()->title }}</h3>
                                            
                                        </div>
                                    </div>
                                </div>
                            </div>
@endforeach
                            
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