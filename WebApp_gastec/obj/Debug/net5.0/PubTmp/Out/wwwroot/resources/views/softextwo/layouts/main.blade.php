

<!DOCTYPE html>
<html>

<head>
        <meta charset="utf-8">
        <title>GASTEC</title>
        <!-- Responsive -->
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">

            <?php
            $actual_link = (isset($_SERVER['HTTPS']) && $_SERVER['HTTPS'] === 'on' ? "https" : "http") . "://$_SERVER[HTTP_HOST]$_SERVER[REQUEST_URI]";
            ?>
            <meta property="og:url" content="{{ $actual_link }}">
        
        
            
        <style>

            svg { position:absolute; bottom:0; left:0}

        </style>
        <!--[if lt IE 9]><script src="js/respond.js"></script><![endif]-->
        
        <script src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/js/jquery.js"></script> 
        
        <script type="text/javascript">
        //remove any externals iframes
        var topHref = '';
        try {
            topHref = top.location.href;
        } catch (e) {
            topHref = '';
        }

        //remove any externals iframes
        if (top.location != location && (topHref == '' || topHref.indexOf('#') != -1)) {
            top.location.href = document.location.href;
        }
    </script>
    </head>
 @include(env("TEMPLATE").'.includes.styles')

</head>
<body>
    <div class="page-wrapper">

            <!-- Preloader -->
           <div class="preloader"></div>
         

    <!-- ==========================
    	HEADER - START
    =========================== -->
     @include(env("TEMPLATE").'.includes.header')
    <!-- ==========================
    	HEADER - END
    =========================== -->

<!--Body-->
    
		
     


            @yield('content')
        



    <!-- PAGE - END -->
    <!-- ==========================
    	FOOTER - START
    =========================== -->
   <!--back to top-->
		


      @include(env("TEMPLATE").'.includes.footer')
@include(env("TEMPLATE").'.includes.scripts')
        </div>

    <!-- ==========================
    	FOOTER - END
    =========================== -->
   	<!-- ==========================
    	JS
    =========================== -->






</body>


</html>
