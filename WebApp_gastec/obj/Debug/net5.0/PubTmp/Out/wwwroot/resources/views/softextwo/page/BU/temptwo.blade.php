   <!--//end backend to retrieve variables  -->
   @foreach ($page->node as $cmsData)
   <?php

            $cmsEditor=$cmsData->attributes()->editor;

            $cmsEditorSecond=$cmsData->attributes()->second_editor;

        
        ?>
   
  @endforeach
 
  
        <!--//Start backend to retrieve variables  -->
        <?php if(\App\System::getCookies()=="ar"){ ?>
        
        
        {!! $cmsEditor !!}
        
        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>

        
        
        {!! $cmsEditorSecond !!}
        
        <?php } ?>
        
        
        
        
        
        
        
        
        
        
        
        
        