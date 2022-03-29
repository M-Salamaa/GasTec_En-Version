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
                    
                    <li>طلب تحويل سيارة</li>
                    
                </ul>
                <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                    <ul class="bread-crumb pull-right">
                    <li><a href="<?=env('APP_URL')?>">Home</a></li>
                    
                    <li>Car Conversion Request</li>
                    
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
                            \App\System::getModule("pagetemptwo","356693780","#cmspage1","<div class='linear-background'></div>");
                            ?>
                        
                        
                    </div>
                </div>
                <!--Form Column-->
                <div class="form-column col-md-7 col-sm-12 col-xs-12">
                <?php
                        if($sent=="1"){
                                         $msg = "تم تقديم طلبك بنجاح";
                                  echo \App\Ui::SuccessMsg($msg);
                        }elseif($sent=='2'){
                            $msg = "حدث خطأ، يرجى اعادة المحاولة";
                            echo \App\Ui::FailedMsg($msg);
                        }
                        ?>
                	<div class="inner-column">
                    <?php if(\App\System::getCookies()=="ar"){ ?>
                            <div class="contact-title text-right">
            	<h2> إرسل لنا طلب تحويل سيارة </h2>
                <div class="text"> لتحويل سيارتك للعمل بالغاز الطبيعي، يرجى استيفاء البيانات التالية وسيقوم احد ممثلي خدمة العملاء بالتواصل معكم</div>
            </div>
            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
<div class="contact-title text-right">
            	<h2>Send to us conversion request</h2>
                <div class="text text-left"> To convert your vehicle to run by Natural Gas, please fill out the following form and a customer service representative will contact you shortly.</div>
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
                                    

                                    <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                        <input type="text" name="Name" value="" placeholder="{{ \App\System::getFinalText('Full Name') }}*" required>
                                    </div>
                                    
                                    <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                        <input type="text" name="UserPhone" value="" placeholder="{{ \App\System::getFinalText('Mobile Number') }}*" required>
                                    </div>

                                    <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                        <input type="text" name="brand" value="" placeholder="{{ \App\System::getFinalText('Car Brand') }}*" required>
                                    </div>
                                    <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                        <input type="text" name="model" value="" placeholder="{{ \App\System::getFinalText('Car Model') }}*" required>
                                    </div>

                                    <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                    <select id="getcountry" required>
                                                <option>{{ \App\System::getFinalText('Country') }}*</option>
                                                @foreach ($states as $state)
                                                <?php if(\App\System::getCookies()=="en"){ ?>
                                                    <option value='{{ $state["catid"] }}'>{{ $state["catname"] }}</option>
                                                    <?php } ?>
                                                    <?php if(\App\System::getCookies()=="ar"){ ?>
                                                    <option value='{{ $state["catid"] }}'>{{ $state["catname_ar"] }}</option>
                                                    <?php } ?>
                                                @endforeach
                                            </select>
                                            <input type="hidden" id="countryname" name="country" >
                                    </div>

                                    <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                        <div id="getformarea"></div>
                                    
                                    </div>

                                    
                                    <div id="getstations"></div>

                                    
                                    <div class="form-group col-md-12 col-sm-12 col-xs-12">
                                    <?php 
											echo \App\Ui::Captcha();
											?>
                                    <?php if(\App\System::getCookies()=="ar"){ ?>
                                        <button type="submit" class="theme-btn btn-style-one pull-right">  إرسال طلبك</button>
                                        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
       <button type="submit" class="theme-btn btn-style-one pull-left">Submit Conversion Request</button>
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
           <script>
               $("#getcountry").change(function () {
                   $("#countryname").val($("#getcountry option:selected").text());
                $.ajax({
                    url: "{{ env('APP_URL') }}getformarea",
                    type: "post",
                    data: "_token={{ csrf_token() }}&countryid=" + $("#getcountry").val(),
                    success: function (htmlinner) {
                     
                            $("#getformarea").html(htmlinner);
                        
                    }
                });
            });
               </script>

                @endsection