@extends(env('TEMPLATE').'.layouts.main')
@section('content')
<!--Page Title-->
    <section class="page-title" style="background-image:url(<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/background/news.jpg);">
        <div class="auto-container">
<!--            <h1>أخبار وفعاليات غازتك</h1>-->
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
                    
                    <li>أخبار وفعاليات غازتك</li>
                    
                </ul>
                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                    <ul class="bread-crumb pull-right">
                    <li><a href="<?=env('APP_URL')?>">Home</a></li>
                    
                    <li>GASTEC News and Events</li>
                    
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
            	
				<!--Content Side-->
                <div class="content-side col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <?php if(\App\System::getCookies()=="ar"){ ?>
                    <div class="services-single" dir="rtl">
                <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       <div class="services-single">
       <?php } ?>	
						<div class="inner-box">
							
                                                    <div id="events1"></div>
                            
                            <?php
                            \App\System::getModule("eventstempfour",$classid,"#events1","please wait..");
                            ?>
                          
                        </div>
                    </div>
                    
                </div>

            </div>
        </div>
    </div>

                @endsection