<script> 
$( document ).ready(function() {
    $( "#sendrequest" ).click(function() {
        $("#thankyou").html("يتم الإرسال");
        $( "#sendrequest" ).remove()
      $.ajax({
        url: "<?= env('APP_URL') ?>index.php/request",
        type: "post",
        data: "_token=<?php echo csrf_token() ;?>&Name=" + $("#nameusr").val() + "&UserPhone=" + $("#UserPhone").val() + "&Email=" + $("#Email").val() + "&Msgdata=" + $("#Msgdata").val() ,
        success: function (response) {
       
            $("#thankyou").html(response);

        }
    }); 
});
});
</script>
<!--Call Back Section-->
            <section class="call-to-action" style="background-image:url(<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/images/background/2.jpg); background-attachment: fixed">
                <div class="auto-container clearfix">
                <?php if(\App\System::getCookies()=="ar"){ ?>
                    <div class="col-md-8 pull-right">
                        <h2 style="color: #fff">للإستفسارات والشكاوى</h2>
                        <h3 style="color: #fff">إتصل بنا او اترك رسالة وسيقوم أحد ممثلي خدمة العملاء بالرد عليك فى أقرب وقت.</h3>
                    </div>
                    <a style="margin-top: 20px" href="#" data-toggle="modal" data-target="#myModal3" class="theme-btn btn-style-one">إرسل طلبك</a>
                    <a style="margin-top: 20px" href="tel:01000016955" class="theme-btn btn-style-one">إتصل بنا</a>
                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       <div class="col-md-8">
                        <h2 style="color: #fff">For inquiries and complaints</h2>
                        <h3 style="color: #fff">Call us or leave a message and our customer service representative will get back to you soon.</h3>
                    </div>
                    <a style="margin-top: 20px" href="#" data-toggle="modal" data-target="#myModal3" class="theme-btn btn-style-one">Send Request</a>
                    <a style="margin-top: 20px" href="tel:01000016955" class="theme-btn btn-style-one">Contact Us</a>
       <?php } ?>

                    

                </div>
            </section>
            <div class="modal fade" id="myModal3" tabindex="-1" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>

                            <div class="signin-form profile">
                                <h3 class="creainfo_sign">{{ \App\System::getFinalText("Contact Us") }}</h3>
                                <div class="login-form">
                                  <div id="thankyou"></div>
                                        <input type="text" name="name" id="nameusr" placeholder="الاسم" required="">
                                        <input type="email" name="email" id="Email" placeholder="البريد الاليكترونى" required="">
                                        <input type="text" name="phone" id="UserPhone" placeholder="رقم الهاتف" required="">
                                        <textarea type="text" name="message" id="Msgdata" placeholder="اترك رسالتك" required=""></textarea>
                                        <input type="submit" id="sendrequest" value="ارسل">
                                    
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--End Call Back Section-->
<!--Main Footer-->
            <footer class="main-footer">
                <div class="container-fluid">
                    <!--Widgets Section-->
                    <div class="widgets-section">
                        
                        <div id="footer1"></div>
                                                     <?php
                            \App\System::getModule("footertempone","0","#footer1","<div class='linear-background'></div>",6000);
                            ?>
                        
                    </div>

                    <!--Footer Bottom-->
                    <div class="footer-bottom">
                        <div class="clearfix">
                            
                            
                            <div class="col-md-12 text-center">
                                
<ul class="social-icon-one">
                                                    <li><a href="https://www.facebook.com/gasteceg/" target="_blank"><span class="fa fa-facebook" target="_blank"></span></a></li>
                                                    <li><a href="https://www.youtube.com/channel/UCTLayD5SdoD3WCPk7T3jgcQ" target="_blank"><span class="fa fa-youtube"></span></a></li>
                                              
                                                   
                                         
                                                </ul>
                               
                                <div class="center">
                               

                                <?php if(\App\System::getCookies()=="ar"){ ?>
                                     <span style="font-size: 16px;font-weight: 600; color: #243a69;">جميع الحقوق محفوظة للشركة المصرية الدولية لتكنولوجيا الغاز - غازتك</span>
                                     <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>

<span style="font-size: 16px;font-weight: 600; color: #243a69;">All rights reserved to the Egyptian International Gas Technology - GASTEC</span>
       <?php } ?>
                                     <div class="copyright">Powered by  <a href="http://softexsw.com" target="_blank">Softex Software House</a> </div>
                            </div>
                            </div>
                        </div>
                    </div>

                </div>

            </footer>