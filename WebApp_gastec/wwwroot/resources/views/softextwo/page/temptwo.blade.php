   <!--//end backend to retrieve variables  -->
   @foreach ($page->node as $cmsData)
   <?php

            $cmsEditor=$cmsData->attributes()->editor;

            $cmsEditorSecond=$cmsData->attributes()->second_editor;

            $cmsEditor=\App\System::HtmlImgCache($cmsEditor);
            $cmsEditorSecond=\App\System::HtmlImgCache($cmsEditorSecond);
        ?>
   
  @endforeach
 
  
        <!--//Start backend to retrieve variables  -->
        <?php if(\App\System::getCookies()=="ar"){ ?>
        
        
        {!! $cmsEditor !!}
        
        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>

        
        
        {!! $cmsEditorSecond !!}
        
        <?php } ?>
        
        
        
        
        
        
        
        
        
        
        
        
        