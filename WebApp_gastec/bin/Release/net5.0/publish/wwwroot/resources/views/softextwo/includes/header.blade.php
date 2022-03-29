<?php
/*$url=url()->current();
$url = str_replace("http","https",$url);*/
?>    

<!-- Main Header-->
            <header class="main-header header-style-four">


                <!--Sticky Header-->
                <div class="sticky-header">
                    <!-- Header Top -->
                <div class="header-top">
                    <div class="auto-container">

                    <?php if(\App\System::getCookies()=="ar"){ ?>

                        <div class="inner-container clearfix">

                            <!--Top left-->
                            <div class="top-left clearfix hidden-sm hidden-xs">
                                <!--social-icon-->
                                <div class="social-icon">
                                    <ul class="clearfix">
                                        <li><a href="https://www.facebook.com/gasteceg/" target="_blank"><span class="fa fa-facebook"></span></a></li>
                                        <li><a href="https://www.youtube.com/channel/UCTLayD5SdoD3WCPk7T3jgcQ" target="_blank"><span class="fa fa-youtube"></span></a></li>

                                    </ul>
                                </div>
                                <ul class="links clearfix">
<li style="padding-top: 8px">|</li>
                                    <li><a href="mailto:gastec@gastec-egypt.com"><span class="icon flaticon-note-1"></span></a></li>
                                    <li><a href="{{ env("APP_URL") }}lang/en"><strong>English</strong><span class="icon flaticon-chat"></span></a></li>
                                    
                                </ul>
                            </div>
<!--Top Right-->
                            <div class="top-right clearfix hidden-sm">
                                <!--social-icon-->
                                <div class="links clearfix">
                                    <ul class="clearfix">
                                        <li><a href="{{ env('APP_URL') }}media_center">المركز الإعلامي </a></li>
                                        <li><a href="{{ env('APP_URL') }}careers">وظائف</a></li>
                                        <li><a href="{{ env('APP_URL') }}contacts">اتصل بنا</a></li>
                                        <li><a href="{{ env('APP_URL') }}conversion_form">طلب تحويل سيارة</a></li>
                                    </ul>
                                </div>
                            </div>

                      
                        </div>
 <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 

<div class="inner-container clearfix">

<!--Top Right-->
<div class="top-right clearfix hidden-sm">
    <!--social-icon-->
    <div class="links clearfix">
        <ul class="clearfix">
            <li><a href="{{ env('APP_URL') }}media_center">Media Center </a></li>
            <li><a href="{{ env('APP_URL') }}careers">Careers</a></li>
            <li><a href="{{ env('APP_URL') }}contacts">Contact Us</a></li>
            <li><a href="{{ env('APP_URL') }}conversion_form">Car Conversion Request</a></li>
        </ul>
    </div>
</div>
<!--Top left-->
<div class="top-left clearfix hidden-sm hidden-xs">
<ul class="links clearfix">

        <li><a href="mailto:gastec@gastec-egypt.com"><span class="icon flaticon-note-1"></span></a></li>
        <li><a href="{{ env("APP_URL") }}lang/ar"><strong>عربى</strong><span class="icon flaticon-chat"></span></a></li>
        <li style="padding-top: 8px">|</li>
    </ul>
    <!--social-icon-->
    <div class="social-icon">
        <ul class="clearfix">
            <li><a href="https://www.facebook.com/gasteceg/" target="_blank"><span class="fa fa-facebook"></span></a></li>
            <li><a href="https://www.youtube.com/channel/UCTLayD5SdoD3WCPk7T3jgcQ" target="_blank"><span class="fa fa-youtube"></span></a></li>

        </ul>
    </div>
    
</div>

</div>

       <?php }?>
                    </div>
                </div>
                <!-- Header Top End -->
                    <div class="auto-container">
                        <div class="sticky-inner-container clearfix">
                            <!--Logo-->
                            <div class="logo pull-right">
                            <?php if(\App\System::getCookies()=="ar"){ ?>
                                <a href="{{ env('APP_URL') }}" class="img-responsive"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/logo-ar.png" alt="" title=""></a>
                                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                                    <a href="{{ env('APP_URL') }}" class="img-responsive"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/logo.png" alt="" title=""></a>
                                    <?php } ?>
                            </div>
                            

                            <!--Right Col-->
                            <div class="right-col pull-left">
                            <!--Outer Box-->
                        <div class="outer-box">
                            <!--Search Box-->
                            <div class="search-box-outer">
                                <div class="dropdown">
                                    <button class="search-box-btn dropdown-toggle" type="button" id="dropdownMenu4" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><span class="fa fa-search"></span></button>
                                    <ul class="dropdown-menu pull-right search-panel" aria-labelledby="dropdownMenu4">
                                        <li class="panel-outer">
                                            <div class="form-container">
                                                <form method="get" action="{{ env('APP_URL') }}searchresult">
                                                    <div class="form-group">
                                                        <input type="text" name="keyword" value="" placeholder="Search Here" required>
                                                        <button type="submit" class="search-btn"><span class="fa fa-search"></span></button>
                                                    </div>
                                                </form>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                                <!-- Main Menu -->
                                
                                        <span id="mainmenu1"></span>
                                                     <?php
                            \App\System::getModule("mainmenutempone","0","#mainmenu1","<div style='padding: 20px 10px;line-height:28px; text-align:right; float:right'>....</div>",3000);
                            ?>
                                  
                                <!-- Main Menu End-->

</div>
                            </div>

                        </div>
                    </div>
              
                <!--End Sticky Header-->
<!--                <div  class="auto-container hidden-xs">
                    <div style="position: absolute; right: 0; padding-top: 20px; text-align: center; width: 192px">
                        <img src="images/tamayuz.png" style="width: 120px" alt="" title="">
                    </div>
                </div>-->
            </header>