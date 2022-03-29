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
                    <li>وظائف خالية</li>
                </ul>
                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                    <ul class="bread-crumb pull-right">
                    <li><a href="<?=env('APP_URL')?>">Home</a></li>
                    <li>Careers</li>
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
			<img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/careers.webp" alt="" />
                        
                    </aside>
                </div>
				<!--Content Side-->
                <div class="content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12">
                <?php if(\App\System::getCookies()=="ar"){ ?>
                    <div class="services-single" dir="rtl">
                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       <div class="services-single" dir="ltr">
       <?php } ?>
						<div class="inner-box">
							
                                                    <div id="cmspage1"></div>
                                                    
                                                     <?php
                            \App\System::getModule("pagetempone","356693644","#cmspage1","<div class='linear-background'></div>");
                            ?>
                          
                                                    
                                                    <div class="team-column col-md-12 col-sm-12 col-xs-12" style="margin-top: 30px">
                	<div class="inner-column">
                    	<div class="row clearfix">
                        <?php
                        if($sent){
                                         $msg = "{{ \App\System::getFinalText('Your Request has been sent!') }}";
                                  echo \App\Ui::SuccessMsg($msg);
                        }
                        ?>
                        	<?php if(\App\System::getCookies()=="ar"){ ?>
                            <div id="careers" dir="rtl"></div>
                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
<div id="careers" dir="ltr"></div>
<?php } ?>

                            <?php
                            \App\System::getModule("careerstempone","0","#careers","<div class='linear-background'></div>");
                            ?>
                           
                        </div>
                    </div>
                </div>
                        </div>
                    </div>
                    
                    
                </div>

            </div>
        </div>
    </div>

                @endsection