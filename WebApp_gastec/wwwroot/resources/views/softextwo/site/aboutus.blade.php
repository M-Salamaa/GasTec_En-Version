@extends(env('TEMPLATE').'.layouts.main')
@section('content')
<?php
$linkimg = $link->attributes()->multiimagesgroup;
$linkcms = $link->attributes()->url;
$linkclass = $link->attributes()->class;
$linkid = $link->attributes()->id;
$linktitle = $link->attributes()->title;
$linktitlesecond = $link->attributes()->second_title;
?>

<!--Page Title-->
    <section class="page-title" style="background-image:url('https://softex-api-endpoint.azurewebsites.net/Cpanel/Links/webservice/viewimage.php?id={{ $linkid }}&imgtype=thumb');">
        <div class="auto-container">
<!--            <h1>{{ $linktitle }}</h1>-->
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
                    
                    <li>{{ $linktitle }}</li>
                    
                </ul>
                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                    <ul class="bread-crumb pull-right">
                    <li><a href="<?=env('APP_URL')?>">Home</a></li>
                    
                    <li>{{ $linktitlesecond }}</li>
                    
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
                	<aside class="sidebar">
			
                              <div id="sidenavelist"></div>
                         <?php
                              \App\System::getModule("sidenav",$linkclass."/".$linkid,"#sidenavelist","<div class='linear-background'></div>",0);
                            
                            ?>
                        
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
							
                                                    <div id="cmspage1"></div>
                            <?php
                            if($linkcms!="http://"){
                            \App\System::getModule("pagetempone",$linkcms,"#cmspage1","<div class='linear-background'></div>",0);
                            }
                            ?>
                          
                        </div>
                    </div>
                    
                    <div class="team-column col-md-12 col-sm-12 col-xs-12" style="margin-top: 30px">
                	<div class="inner-column">
                    	<div class="row clearfix">
                        	
                     
                            
                               <?php
                            if($linkimg!=""){
                                ?>
                             <div id="teambox"></div>
                            <?php
                            \App\System::getModule("galtempone",$linkimg,"#teambox","<div class='linear-background'></div>");
                            }
                            ?>
                           
                        </div>
                    </div>
                </div>
                </div>

            </div>
        </div>
    </div>
    
   
      <?php
                            if($linkcms!="http://"){
                                ?>
   {!!  \App\System::getURLData("cmsmeta/".$linkcms) !!}
                            <?php } ?>

                @endsection