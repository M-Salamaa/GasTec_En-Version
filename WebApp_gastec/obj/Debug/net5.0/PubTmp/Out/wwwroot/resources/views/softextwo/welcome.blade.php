<?php
include_once(app_path() . '/../includes/security/Validation.php');
?> 
@extends(env('TEMPLATE').'.layouts.main')
@section('content')  

           <!--Main Slider-->
    
    	
        <div id="mainslider"></div>
        <?php if(\App\System::getCookies()=="ar"){ ?>
            <?php
                            \App\System::getModule("galtempfour","1190","#mainslider","<div class='linear-background'></div>",0);
                            ?>
               <?php }  elseif(\App\System::getCookies()=="en"){ ?>      
                <?php
                            \App\System::getModule("galtempfour","1247","#mainslider","<div class='linear-background'></div>",0);
                            ?>
                <?php } ?>



        
        

    <!--End Main Slider-->



            <!--About Section-->
            <section class="aproach-section bg-wave">
                <div class="auto-container">

                <?php if(\App\System::getCookies()=="ar"){ ?>

                    <div class="sec-title">
                        <h2>أحدث الأخبار <a href="<?=env('APP_URL')?>allnews/32688" class="theme-btn read-more" style="float: left;direction: rtl;font-size: 18px;">عرض جميع الأخبار<span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a> </h2>

                    </div>

                    <?php } 
       
        elseif(\App\System::getCookies()=="en"){ ?>

                  <div class="sec-title">
                        <h2>Latest News <a href="<?=env('APP_URL')?>allnews/32688" class="theme-btn read-more" style="float: right;direction: ltr;font-size: 18px;">View all news<span class="icon flaticon-right-arrow-1" style="margin-left: 10px;font-size: 20px;vertical-align: sub;"></span></a> </h2>

                    </div>

        <?php } ?> 

                     <div id="events1" class="row clearfix"></div>
                    
                 
                    
                     <?php
                            \App\System::getModule("eventstempone","32688","#events1","<div class='linear-background'></div>");
                            ?>
                </div>
            </section>
            <!--End About Section-->
            
            
            <!--Counter Section-->
            <section class="counter-section" style="background-image:url(<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/background/action1.jpg);background-size: cover;">
                <div class="auto-container">
                    <div class="row clearfix">
  <!--Image Column-->
  <?php if(\App\System::getCookies()=="ar"){ ?>
                        <div class="image-column col-lg-2 col-md-12 col-sm-12 pull-right wow slideInUp">
                            <div class="image">
                                <h1>أرقام غازتك</h1>
                            </div>
                            
                            <h1 class="cng">CNG for Mobility</h1>
                        </div>
                        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
<div class="image-column col-lg-2 col-md-12 col-sm-12 pull-left wow slideInUp">
                            <div class="image">
                                <h1>GASTEC Numbers</h1>
                            </div>
                            
                            <h1 class="cng">CNG for Mobility</h1>
                        </div>
       <?php } ?>
       <?php
         $numbers1 = $numbers1->node[0]->attributes()->actual_url;
         $numbers2 = $numbers2->node[0]->attributes()->actual_url;
         $numbers3 = $numbers3->node[0]->attributes()->actual_url;
         $numbers4 = $numbers4->node[0]->attributes()->actual_url;

              ?>
       <?php if(\App\System::getCookies()=="ar"){ ?>
                        <!--Counter Column-->
                        <div class="counter-main-column col-lg-10 col-md-12 col-sm-12">
                            <div class="inner-column">

                                <div class="fact-counter">

                                    <div class="row clearfix"> 
                                        <!--Column-->
                                        <div class="column counter-column col-lg-3 col-md-3 col-sm-6 col-xs-6 wow fadeIn" data-wow-delay=".70s">
                                            <div class="card-top"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/card-top.png" alt="" /></div>
                                            <div class="inner">
                                                <div class="count-outer count-box">
                                                    <span class="count-text" data-speed="3500" data-stop="{{ $numbers1 }}">0</span>
                                                </div>
                                                 <img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/count1.png" alt="" />
                                                <h4 class="counter-title">محطات الوقود السائل</h4>
                                            </div>
                                        </div>

                                        <!--Column-->
                                        <div class="column counter-column col-lg-3 col-md-3 col-sm-6 col-xs-6 wow fadeIn" data-wow-delay=".60s">
                                            <div class="card-top"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/card-top.png" alt="" /></div>
                                            <div class="inner">
                                               
                                                <div class="count-outer count-box">
                                                    <span class="count-text" data-speed="2500" data-stop="{{ $numbers2 }}">0</span>مليار م3
                                                </div>
                                                <img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/count2.png" alt="" />
                                                <h4 class="counter-title">مبيعات الغاز</h4>
                                            </div>
                                        </div>

                                        <!--Column-->
                                        <div class="column counter-column col-lg-3 col-md-3 col-sm-6 col-xs-6 wow fadeIn" data-wow-delay=".50s">
                                            <div class="card-top"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/card-top.png" alt="" /></div>
                                            <div class="inner">
                                                <div class="count-outer count-box">
                                                    <span class="count-text" data-speed="2000" data-stop="{{ $numbers3 }}">0</span>
                                                </div>
                                                <img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/count3.png" alt="" />
                                                <h4 class="counter-title">سيارة محولة</h4>
                                            </div>
                                        </div>
                                        
                                         <!--Column-->
                                        <div class="column counter-column col-lg-3 col-md-3 col-sm-6 col-xs-6 wow fadeIn" data-wow-delay=".40s">
                                            <div class="card-top"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/card-top.png" alt="" /></div>
                                            <div class="inner">
                                                <div class="count-outer count-box">
                                                    <span class="count-text" data-speed="2500" data-stop="{{ $numbers4 }}">0</span>محطة
                                                </div>
                                                <img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/count4.png" alt="" />
                                                <h4 class="counter-title">محطات الغاز الطبيعي</h4>
                                            </div>
                                        </div>

                                    </div>

                                </div>

                            </div>
                        </div>
                        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
                      <div class="counter-main-column col-lg-10 col-md-12 col-sm-12">
                            <div class="inner-column">

                                <div class="fact-counter">

                                    <div class="row clearfix"> 
                                        <!--Column-->
                                        <div class="column counter-column col-lg-3 col-md-3 col-sm-6 col-xs-6 wow fadeIn" data-wow-delay=".70s">
                                            <div class="card-top"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/card-top.png" alt="" /></div>
                                            <div class="inner">
                                                <div class="count-outer count-box">
                                                    <span class="count-text" data-speed="3500" data-stop="{{ $numbers1 }}">0</span>
                                                </div>
                                                 <img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/count1.png" alt="" />
                                                <h4 class="counter-title">Liquid Fuel Stations</h4>
                                            </div>
                                        </div>

                                        <!--Column-->
                                        <div class="column counter-column col-lg-3 col-md-3 col-sm-6 col-xs-6 wow fadeIn" data-wow-delay=".60s">
                                            <div class="card-top"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/card-top.png" alt="" /></div>
                                            <div class="inner">
                                               
                                                <div class="count-outer count-box">
                                                    <span class="count-text" data-speed="2500" data-stop="{{ $numbers2 }}">0</span> Bilion M3
                                                </div>
                                                <img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/count2.png" alt="" />
                                                <h4 class="counter-title">Gas sales</h4>
                                            </div>
                                        </div>

                                        <!--Column-->
                                        <div class="column counter-column col-lg-3 col-md-3 col-sm-6 col-xs-6 wow fadeIn" data-wow-delay=".50s">
                                            <div class="card-top"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/card-top.png" alt="" /></div>
                                            <div class="inner">
                                                <div class="count-outer count-box">
                                                    <span class="count-text" data-speed="2000" data-stop="{{ $numbers3 }}">0</span>
                                                </div>
                                                <img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/count3.png" alt="" />
                                                <h4 class="counter-title">Converted Vehicle</h4>
                                            </div>
                                        </div>
                                        
                                         <!--Column-->
                                        <div class="column counter-column col-lg-3 col-md-3 col-sm-6 col-xs-6 wow fadeIn" data-wow-delay=".40s">
                                            <div class="card-top"><img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/card-top.png" alt="" /></div>
                                            <div class="inner">
                                                <div class="count-outer count-box">
                                                    <span class="count-text" data-speed="2500" data-stop="{{ $numbers4 }}">0</span>Station
                                                </div>
                                                <img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/count4.png" alt="" />
                                                <h4 class="counter-title">Natural Gas Stations</h4>
                                            </div>
                                        </div>

                                    </div>

                                </div>

                            </div>
                        </div>

                        <?php } ?>
                    </div>
                </div>
            </section>
            <!--End Counter Section-->
       


            <section class="services-section" style="background:#ffd41f">
               
                <div class="auto-container">
                <?php if(\App\System::getCookies()=="ar"){ ?>
                    <div class="col-md-3 col-sm-12 col-xs-12 news-block pull-left text-left wow slideInLeft" style="padding-top:50px; padding-bottom: 30px; direction: rtl;">
                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
 <div class="col-md-3 col-sm-12 col-xs-12 news-block pull-right text-right wow slideInLeft" style="padding-top:50px; padding-bottom: 30px; direction: rtl;">
 <?php }?>
                    <img src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/eni-logo.png" alt="">
                       
                    </div>
                    
                    
                    <div class="col-md-9 col-sm-12 col-xs-12 pull-right">
                    <?php if(\App\System::getCookies()=="ar"){ ?>
                        <div dir="rtl">
                        <h1 style="padding-bottom: 10px">إينى – غازتك</h1>
                        <h2 style="padding-bottom: 30px">شراكة استراتيجية لتطوير خدمات التموين وتوزيع الزيوت</h2>
                        </div>
                        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       <div>
                        <h1 style="padding-bottom: 10px">Eni - GASTEC</h1>
                        <h2 style="padding-bottom: 30px">A strategic partnership to develop catering services and Lubricants</h2>
                        </div>
                        <?php }?>
                        <div class="row clearfix">
            <!--Column-->
            	
            	<!--Column-->
            	<div class="column col-md-12 col-sm-12">
                     
                	<div class="row clearfix">
						
                        <!--News Block-->
                        
                        
                        <!--News Block-->
                       
                          
                        <div id="events2"></div>
                        <?php
                            \App\System::getModule("eventstemptwo","32689","#events2","<div class='linear-background'></div>");
                            ?>
                        
                        <?php if(\App\System::getCookies()=="ar"){ ?>
                            <div dir="rtl">
                            <a href="<?=env('APP_URL')?>allnews/32689" class="theme-btn read-more">المزيد من الأخبار<span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a>
                            </div>
                            <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
                         <div>
                            <a href="<?=env('APP_URL')?>allnews/32689" class="theme-btn read-more">View More <span class="icon flaticon-right-arrow-1" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a>
                            </div>
       <?php } ?>
                    </div>
                </div>
                
                
                
            </div>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="container-fluid">

                <div id="gallerybanner"></div>
                <?php if(\App\System::getCookies()=="ar"){ ?>
                            <?php
                            \App\System::getModule("galbanner","1195","#gallerybanner","<div class='linear-background'></div>");
                            ?>
               <?php }  elseif(\App\System::getCookies()=="en"){ ?>      
                <?php
                            \App\System::getModule("galbanner","1245","#gallerybanner","<div class='linear-background'></div>");
                            ?>
                <?php } ?>

                        </div>
                	<div class="auto-container">
        	
            
                            <div id="gallery3"></div>
                            <?php
                            \App\System::getModule("galtempthree","1189","#gallery3","<div class='linear-background'></div>");
                            ?>
                            
                            <?php if(\App\System::getCookies()=="ar"){ ?>
                            <div class="text-left" style="margin-top: 30px" dir="rtl"> <a href="https://oilproducts.eni.com/en_GB/products" target="_blank" class="theme-btn read-more" style="font-size: 18px;">موقع إيني العالمية<span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a></div>
                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       
       <div class="text-right" style="margin-top: 30px"> <a href="https://oilproducts.eni.com/en_GB/products" target="_blank" class="theme-btn read-more" style="font-size: 18px;">Eni Global Website <span class="icon flaticon-right-arrow-1" style="margin-left: 10px;font-size: 20px;vertical-align: sub;"></span></a></div>
       <?php } ?>
        </div>
            </section>


            

            <!--News Section-->
            <section class="project-section">
                <div class="auto-container">
                <?php if(\App\System::getCookies()=="ar"){ ?>
                    <div class="sec-title">
                        <h2>فعاليات غازتك<a href="<?=env('APP_URL')?>allnews/32690" class="theme-btn read-more" style="float: left;direction: rtl;font-size: 18px;color: #fff;">عرض جميع الفعاليات<span class="icon flaticon-left-arrow" style="margin-right: 10px;font-size: 20px;vertical-align: sub;"></span></a></h2>

                    </div>
                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
 <div class="sec-title">
                        <h2>GASTEC Events <a href="<?=env('APP_URL')?>allnews/32690" class="theme-btn read-more" style="float: right;direction: ltr;font-size: 18px;color: #fff;">View All Events <span class="icon flaticon-right-arrow-1" style="margin-left: 10px;font-size: 20px;vertical-align: sub;"></span></a></h2>

                    </div>
       <?php } ?>

                    <div class="row clearfix">

                        <!--Column-->
                        <div class="column col-md-12 col-sm-12 col-xs-12">
                            <div class="row clearfix">

                                <div id="events3"></div>
                            <?php
                            \App\System::getModule("eventstempthree","32690","#events3","<div class='linear-background'></div>");
                            ?>
                                
                            </div>
                        </div>

                    </div>

                </div>
            </section>
            <!--End News Section-->

<!--================Map Area =================-->
<div class="row" style="background-color: #bdd2e2; margin: 0;">
<?php
$getGovernorats = \App\System::getGovernorat();
  ?>
  
<?php if(\App\System::getCookies()=="ar"){ ?>
<div class="col-md-3 col-xs-12 pull-right text-right">
<h1>خدمات غازتك</h1>
<select id="getGovernorat" style="width: 100%; padding:10px;direction:rtl">
    <option value="0">كل المحافظات</option>
    @foreach ($getGovernorats as $getGovernorat)
    <option value="{{ $getGovernorat['id'] }}">
  {{ $getGovernorat['namear'] }}
  </option>
  @endforeach
    </select>
</div>

    <?php }elseif(\App\System::getCookies()=="en"){ ?> 
        <div class="col-md-3 col-xs-12">
<h1>GASTEC Services</h1>
<select id="getGovernorat" style="width: 100%; padding:10px;">
      <option value="0">All Governorates</option>
     
@foreach ($getGovernorats as $getGovernorat)
  <option value="{{ $getGovernorat['id'] }}">
    {{ $getGovernorat['name'] }}
  </option>
  @endforeach
</select>
</div>
<?php } ?>
</div>
<div id="locationmap"></div>

<?php
                \App\System::showMap();
?>


            <!--End Call Back Section-->
<script>
$( "#getGovernorat" ).change(function() {
   $.ajax({
                type: 'POST',
                url:  "<?= env('APP_URL') ?>index.php/geomap/0",
                data : "_token=<?php echo csrf_token(); ?>&getlat=1&getlong=2",
                }).success(function(response) {

                   $("#locationmap").html(response);
                    
                });
            });

</script>
           @include('softextwo.includes.map-no-locations-popup')
              @endsection
