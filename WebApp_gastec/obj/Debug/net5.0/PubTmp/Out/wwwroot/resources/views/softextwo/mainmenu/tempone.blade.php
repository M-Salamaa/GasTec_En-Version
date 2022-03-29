

<nav class="main-menu">
                                    <div class="navbar-header">
                                        <!-- Toggle Button -->    	
                                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                                            <span class="icon-bar"></span>
                                            <span class="icon-bar"></span>
                                            <span class="icon-bar"></span>
                                        </button>
                                    </div>

                                    
                                    <div class="navbar-collapse collapse clearfix">
                                    <?php if(\App\System::getCookies()=="ar"){ ?>
<ul class="navigation clearfix">
                                            <li><a href="{{ env('APP_URL') }}">الرئيسية</a></li>
                                          
                                      
                                            @foreach ($getmenu as $getmenudata)
                                      <?php
                                           
                                         
                                      if($getmenudata["id"]=="32694"){
                                          continue;
                                      }
                                      ?>
                                            <li class="dropdown"> <a href="#">{{ $getmenudata["name"] }}</a>
                                        
                                                <ul>
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
                                                    ?>
                                                    <li> <a href="{{ $linkfullurl . $gesubmenudata["id"] }}">{{ $gesubmenudata["title"] }}</a> </li>
                                                    @endforeach
                                                <?php
                                                if($getmenudata["id"]==32693){
                                                ?>
                                                    <li class="dropdown"> <a href="#">الموارد البشرية </a> 
                                                        <ul>
                                                            @foreach ($getmenuhr as $getmenuhrdata)
                                                            @foreach ($getmenuhrdata["linksdata"] as $gesubmenudatahr)
                                                            <?php
                                                                $linkfullurlsub = env('APP_URL')."hr/";
                                                            ?>
                                                    <li> <a href="{{ $linkfullurlsub.$gesubmenudatahr["id"] }}">{{ $gesubmenudatahr["title"] }}</a> </li>
                                                            @endforeach
                                                            @endforeach
                                                        </ul>
                                                    </li>
                                                <?php } ?>
                                                </ul>
                                                
                                            </li>
                                            @endforeach
                                           

                                        </ul>

                                        <?php } 
       
        elseif(\App\System::getCookies()=="en"){ ?>

<ul class="navigation clearfix">
                                            <li><a href="{{ env('APP_URL') }}">Home</a></li>
                                          
                                      
                                      @foreach ($getmenu as $getmenudata)
                                      <?php
                                           
                                         
                                      if($getmenudata["id"]=="32694"){
                                          continue;
                                      }
                                      ?>
                                      <?php if(\App\System::getCookies()=="ar"){ ?>
                                            <li class="dropdown"> <a href="#">{{ $getmenudata["name"] }}</a>
                                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
                                        <li class="dropdown"> <a href="#">{{ $getmenudata["second_name"] }}</a>
       <?php } ?>
                                                <ul>
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
                                                    ?>
<?php if(\App\System::getCookies()=="ar"){ ?>

                                                    <li> <a href="{{ $linkfullurl . $gesubmenudata["id"] }}">{{ $gesubmenudata["title"] }}</a> </li>
                                                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
                                                    <li> <a href="{{ $linkfullurl . $gesubmenudata["id"] }}">{{ $gesubmenudata["second_title"] }}</a> </li>
       <?php } ?>

                                                    @endforeach
                                                <?php
                                                if($getmenudata["id"]==32693){
                                                ?>
                                                    <li class="dropdown"> <a href="#">HR </a> 
                                                        <ul>
                                                            @foreach ($getmenuhr as $getmenuhrdata)
                                                            @foreach ($getmenuhrdata["linksdata"] as $gesubmenudatahr)
                                                            <?php
                                                                $linkfullurlsub = env('APP_URL')."hr/";
                                                            ?>
<?php if(\App\System::getCookies()=="ar"){ ?>

                                                    <li> <a href="{{ $linkfullurlsub.$gesubmenudatahr["id"] }}">{{ $gesubmenudatahr["title"] }}</a> </li>
                                                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>            
                                                    <li> <a href="{{ $linkfullurlsub.$gesubmenudatahr["id"] }}">{{ $gesubmenudatahr["second_title"] }}</a> </li>
                                                    <?php } ?>

                                                    @endforeach
                                                            @endforeach
                                                        </ul>
                                                    </li>
                                                <?php } ?>
                                                </ul>
                                                
                                            </li>
                                            @endforeach
                                           

                                        </ul>
                                        <?php } ?> 
                                    </div>
</nav>
<script>
    
	//Update Header Style and Scroll to Top
	function headerStyle() {
		if($('.main-header').length){
			var windowpos = $(window).scrollTop();
			var siteHeader = $('.main-header');
			
			var scrollLink = $('.scroll-to-top');
			if (windowpos >= 1) {
				siteHeader.addClass('fixed-header');
				scrollLink.fadeIn(0);
			} else {
				siteHeader.removeClass('fixed-header');
				scrollLink.fadeOut(0);
			}
		}
	}
	
	headerStyle();
	
	
	//Submenu Dropdown Toggle
	if($('.main-header li.dropdown ul').length){
		$('.main-header li.dropdown').append('<div class="dropdown-btn"><span class="fa fa-angle-down"></span></div>');
		
		//Dropdown Button
		$('.main-header li.dropdown .dropdown-btn').on('click', function() {
			$(this).prev('ul').slideToggle(500);
		});
		
		//Disable dropdown parent link
		$('.main-header .navigation li.dropdown > a,.hidden-bar .side-menu li.dropdown > a').on('click', function(e) {
			e.preventDefault();
		});
	}
	
    </script>
    
    

