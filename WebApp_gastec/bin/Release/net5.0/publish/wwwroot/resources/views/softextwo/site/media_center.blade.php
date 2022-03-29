@extends(env('TEMPLATE').'.layouts.main')
@section('content')
<!--Page Title-->
    <section class="page-title" style="background-image:url(<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/background/4.jpg);">
        <div class="auto-container">
<!--            <h1>المركز الإعلامي</h1>-->
        </div>
        
    </section>
    <!--End Page Title-->
    
    <!--Page Info-->
    <div class="page-info">
        <div class="auto-container">
        <div class="inner-container clearfix">
            <?php if(\App\System::getCookies()=="ar"){ ?>
                <ul class="bread-crumb pull-right">
                    <li><a href="<?=env('APP_URL')?>">الرئيسية</a></li>
                    
                    <li>المركز الإعلامي</li>
                    
                </ul>
                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                    <ul class="bread-crumb pull-right">
                    <li><a href="<?=env('APP_URL')?>">Home</a></li>
                    
                    <li>Media Center</li>
                    
                </ul>
                        <?php } ?>
             
            </div>

        </div>
    </div>
    <!--End Page Info-->
        
        
    <!--Sidebar Page Container-->
    <div class="sidebar-page-container">
    	<div class="auto-container">
        	<div class="row clearfix">
            	<!--Sidebar Side-->
                <?php if(\App\System::getCookies()=="ar"){ ?>
                <div class="sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-right">
                <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       <div class="sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-left">
       <?php } ?>	
       <?php if(\App\System::getCookies()=="ar"){ ?>
                	<aside class="sidebar">
						
                        <!--Blog Category Widget-->
                        <div class="sidebar-widget sidebar-blog-category">
                            <ul class="blog-cat">
                                <li class="active"><a href="{{ env('APP_URL') }}media_center">أحدث الأخبار</a></li>
                                <li><a href="{{ env('APP_URL') }}imggallery">معرض الصور</a></li>
                                <li><a href="{{ env('APP_URL') }}videos">فيديوهات </a></li>
                                <li><a href="{{ env('APP_URL') }}activitiesphotos">صور الأنشطة </a></li>
                                <li><a href="{{ env('APP_URL') }}mediafiles">تقارير ومطبوعات </a></li>
                            </ul>
                        </div>
                        
                        <!--Brochure-->
                    	<div class="sidebar-widget brochure-widget" style="display:none">
                            
                            <div class="brochure-box">
                            	<div class="inner">
                                	<span class="icon flaticon-file" style="color: #fff;"></span>
                                	<div class="text">تحميل بروشور غازتك</div>
                                </div>
                                <a href="#" class="overlay-link"></a>
                            </div>
                            
                        </div>

                    </aside>
                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 

<aside class="sidebar">
						
                        <!--Blog Category Widget-->
                        <div class="sidebar-widget sidebar-blog-category">
                            <ul class="blog-cat">
                                <li class="active"><a href="{{ env('APP_URL') }}media_center">Latest News</a></li>
                                <li><a href="{{ env('APP_URL') }}imggallery">Image Gallery</a></li>
                                <li><a href="{{ env('APP_URL') }}videos">Videos </a></li>
                                <li><a href="{{ env('APP_URL') }}activitiesphotos">Activities Photos </a></li>
                                <li><a href="{{ env('APP_URL') }}mediafiles">Reports & Print outs </a></li>
                                
                            </ul>
                        </div>
                        
                        <!--Brochure-->
                    	<div class="sidebar-widget brochure-widget" style="display:none">
                            
                            <div class="brochure-box">
                            	<div class="inner">
                                	<span class="icon flaticon-file" style="color: #fff;"></span>
                                	<div class="text">Download GASTEC Brochure</div>
                                </div>
                                <a href="#" class="overlay-link"></a>
                            </div>
                            
                        </div>

			
                        
                    </aside>

<?php } ?>
                </div>
				<!--Content Side-->
                <div class="content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12">
                <?php if(\App\System::getCookies()=="ar"){ ?>
                    <div class="services-single" dir="rtl">
                <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       <div class="services-single">
       <?php } ?>	
						<div class="inner-box">
							
                                                    <div id="events1"></div>
                            
                            <?php
                            \App\System::getModule("eventstempfour","32688","#events1","<div class='linear-background'></div>");
                            ?>
                          
                        </div>
                    </div>
                    
                    
                </div>

            </div>
        </div>
    </div>

                @endsection