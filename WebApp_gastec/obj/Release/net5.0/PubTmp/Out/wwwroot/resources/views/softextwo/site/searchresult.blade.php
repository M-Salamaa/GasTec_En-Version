@extends(env('TEMPLATE').'.layouts.main')
@section('content')
<!--Page Title-->
    <section class="page-title" style="background-image:url(<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/background/4.jpg);">
        <div class="auto-container">
<!--            <h1>عن غازتك</h1>-->
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
                    
                    
                </ul>
                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                    <ul class="bread-crumb">
                    <li><a href="<?=env('APP_URL')?>">Home</a></li>
                    
                    
                </ul>
                        <?php } ?>
            </div>
        </div>
    </div>
    <!--End Page Info-->
        
        
    <!--Sidebar Page Container-->
{{--m.fathy todo handle layout direction in language chnaged--}}
@if(\App\System::getCookies()=="en")
<style>
    .auto-container h2,.auto-container h4{
        text-align: left;
    }
</style>
@endif
    <div class="sidebar-page-container" style="">
    	<div class="auto-container">
        	<div class="row clearfix">
            	<!--Sidebar Side-->
           
				<!--Content Side-->
                <div class="content-side col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="auto-container text-right">
                                <h2>{{\App\System::getFinalText('search-results')}}</h2>
                                <hr>
                                <div id="searchblocks"></div>
                                <?php
                            \App\System::getModule("searchtempone","0?keyword=".$_GET["keyword"],"#searchblocks","<div class='linear-background'></div>");
                            ?>
                </div>
                  
                </div>

            </div>
        </div>
    </div>

                @endsection