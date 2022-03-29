<section class="ct-section--grey text-center ">
    <div class="text-right">

            <div class="seventhStyle"></div>
      
   </div>
</section>

  <!-- Maps -->

<script src="<?=env('APP_URL')?>maps/js/device.min.js"></script>
<script src="<?=env('APP_URL')?>maps/js/jquery.browser.min.js"></script>
<script>

var getlong = "{{ $_POST["getlong"] }}";
var getlat = "{{ $_POST["getlat"] }}";

</script>

<?php if(\App\System::getCookies()=="ar"){ ?>
  <script src="<?=env('APP_URL')?>src/shop-locator.min.js?v=1.4"></script>
                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
 <script src="<?=env('APP_URL')?>src/shop-locator-en.min.js?v=1.4"></script>
       <?php } ?>


<script src="<?=env('APP_URL')?>maps/js/splash.js"></script>