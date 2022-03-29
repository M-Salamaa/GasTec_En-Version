@extends(env('TEMPLATE').'.layouts.main')
@section('content')
<!--Page Title-->
    <section class="page-title" style="background-image:url(<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/background/4.jpg);">
        <div class="auto-container">
<!--            <h1>إتصل بنا</h1>-->
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
                    
                    <li>إتصل بنا</li>
                    
                </ul>
                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                    <ul class="bread-crumb pull-right">
                    <li><a href="<?=env('APP_URL')?>">Home</a></li>
                    
                    <li>Contact Us</li>
                    
                </ul>
                        <?php } ?>
             
            </div>

        </div>
    </div>
    <!--End Page Info-->

                        
                                <!--Contact Section-->
    <section class="contact-section">
    	<div class="auto-container">
        	
        	<div class="row clearfix">
                <!--Info Column-->
                <?php if(\App\System::getCookies()=="ar"){ ?>
                <div class="info-column col-md-5 col-sm-12 col-xs-12">
                <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
       <div class="info-column col-md-5 col-sm-12 col-xs-12 pull-right">
       <?php } ?>
                	<div class="inner-column">
                    <?php if(\App\System::getCookies()=="ar"){ ?>
                            <div id="cmspage1" style="text-align: right"></div>
                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
       <div id="cmspage1" style="text-align: left"></div>
       <?php } ?>
                                                     <?php
                            \App\System::getModule("pagetempone","356693645","#cmspage1","<div class='linear-background'></div>");
                            ?>
                        
                        
                    </div>
                </div>
                <!--Form Column-->
                <div class="form-column col-md-7 col-sm-12 col-xs-12">
                <?php
                        if($sent){
                                         $msg = "تم تقديم طلبك بنجاح";
                                  echo \App\Ui::SuccessMsg($msg);
                        }
                        ?>
                	<div class="inner-column">
                    <?php if(\App\System::getCookies()=="ar"){ ?>
                            <div class="contact-title text-right">
            	<h2>إرسل لنا </h2>
                <div class="text"> لأن اهتماماتك أولويتنا يرجى التكرم بملء النموذج أدناه سواءً كان ذلك استفساراً أو سؤالاً يتعلق بمنتجاتنا أو خدمتنا</div>
            </div>
            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
<div class="contact-title text-right">
            	<h2>Send to Us</h2>
                <div class="text text-left"> Because your interests are our priority, please kindly fill out the form below, whether it is an inquiry or a question related to our products or services.</div>
            </div>
       <?php } ?>

                    	<!--Contact Form-->
                        <div class="contact-form">
                        <?php if(\App\System::getCookies()=="ar"){ ?>
                            <form method="post" action="" id="contact-form" dir="rtl">
                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
        <form method="post" action="" id="contact-form" dir="ltr">
        <?php } ?>
                                <div class="row clearfix">
                                <input type="hidden" name="_token" value="{{csrf_token()}}">
                                    

                                    <div class="form-group col-md-12 col-sm-12 col-xs-12">
                                        <input type="text" name="Name" value="" placeholder="{{ \App\System::getFinalText('Name') }}" required>
                                    </div>
                                    <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                        <input type="text" name="Email" value="" placeholder="{{ \App\System::getFinalText('Email') }}" required>
                                    </div>
                                    
                                    <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                        <input type="text" name="UserPhone" value="" placeholder="{{ \App\System::getFinalText('Phone Number') }}" required>
                                    </div>
                                    
                                    <div class="form-group col-md-12 col-sm-12 col-xs-12">
                                        <textarea name="message" placeholder="{{ \App\System::getFinalText('Your Message') }}"></textarea>
                                    </div>
                                    
                                    <div class="form-group col-md-12 col-sm-12 col-xs-12">
                                    <?php if(\App\System::getCookies()=="ar"){ ?>
                                        <button type="submit" class="theme-btn btn-style-one pull-right">إرسال</button>
                                        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
       <button type="submit" class="theme-btn btn-style-one pull-left">Send</button>
       <?php } ?>
                                    </div>                                        
                                </div>
                            </form>
                        </div>
                        <!--End Contact Form-->
                    </div>
                </div>
                
                
                
            </div>
        </div>
    </section>
    <!--End Contact Section-->
           

                @endsection