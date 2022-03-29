

<!DOCTYPE html>
<html>

<head>
        <meta charset="utf-8">
        <title>GASTEC</title>
        <!-- Responsive -->
        <link href="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/css/sb-admin-2.min.css" rel="stylesheet">
        <script src="<?=env('APP_URL')?>assets/<?php echo env('TEMPLATE') ;?>/js/jquery.js"></script> 

    </head>


</head>
<body id="page-top">

    <!-- Page Wrapper -->
    <div id="wrapper">

    
<!-- Content Wrapper -->
<div id="content-wrapper" class="d-flex flex-column">

<!-- Main Content -->
<div id="content">

    <!-- Topbar -->
    <nav class="navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow">

       <h2 style="display: block;width: 100%">GASTEC <a href="{{ env('APP_URL') }}logout" class="btn btn-primary" style="float: right;">Logout</a></h2>
      
    </nav>
    <!-- End of Topbar -->

     <!-- Begin Page Content -->
 <div class="container-fluid">
            @yield('content')
        
</div>
</div>
<!-- End of Main Content -->

<!-- Footer -->
<footer class="sticky-footer bg-white">
    <div class="container my-auto">
        <div class="copyright text-center my-auto">
            <span>Copyright &copy; <a href="http://www.softexsw.com" target="_blank">Softex Software House</a> 2020</span>
        </div>
    </div>
</footer>
<!-- End of Footer -->

</div>
<!-- End of Content Wrapper -->




    <!-- PAGE - END -->
    <!-- ==========================
    	FOOTER - START
    =========================== -->
   <!--back to top-->
		

        </div>

    <!-- ==========================
    	FOOTER - END
    =========================== -->
   	<!-- ==========================
    	JS
    =========================== -->






</body>


</html>
