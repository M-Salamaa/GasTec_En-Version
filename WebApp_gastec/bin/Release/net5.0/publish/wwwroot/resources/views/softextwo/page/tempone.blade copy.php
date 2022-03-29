   <!--//end backend to retrieve variables  -->
    @foreach ($page->node as $cmsData)
   <?php
            $cmsTitle=$cmsData->attributes()->title;
            $cmsEditor=$cmsData->attributes()->editor;
            $cmsTitleSecond=$cmsData->attributes()->second_title;
            $cmsEditorSecond=$cmsData->attributes()->second_editor;

        
        ?>
   
  @endforeach
 
  
        <!--//Start backend to retrieve variables  -->
        <?php if(\App\System::getCookies()=="ar"){ ?>
         <h2>{{ $cmsTitle  }}</h2>
        
        
        {!! $cmsEditor !!}
        
        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>

        <h2>{{ $cmsTitleSecond  }}</h2>
        
        
        {!! $cmsEditorSecond !!}
        
        <?php } ?>
        
        
        
        
        
        
        
        
        
        
        
        
        