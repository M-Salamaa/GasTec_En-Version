@extends(env('TEMPLATE').'.layouts.main')
@section('content')

<!--Page Title-->
    <section class="page-title" style="background-image:url(<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/background/4.jpg);">
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
                    
                    <li>معرض الصور</li>
                    
                </ul>
                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                    <ul class="bread-crumb pull-right">
                    <li><a href="<?=env('APP_URL')?>">Home</a></li>
                    
                    <li>Image Gallery</li>
                    
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
                
                            <div id="imgfull"></div>
                            
                            <?php
                            \App\System::getModule("imgfull",$imageid,"#imgfull","<div class='linear-background'></div>");
                            ?>
            </div>
        </div>
    </div>

                @endsection