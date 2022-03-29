
<ul class="nav nav-tabs" dir="rtl">
      <?php $counter = 0 ;?>
      @foreach ($getclassesmain as $getclassesmaindata)
    <li class="@if ($counter == 0) active @endif"><a data-toggle="tab" href="#cat{{ $getclassesmaindata['id'] }}">
    <?php if(\App\System::getCookies()=="ar"){ ?>
      {{ $getclassesmaindata["name"] }} 
      <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
        {{ $getclassesmaindata["second_name"] }} 
        <?php } ?>
    </a></li>
    <?php $counter++;?>
    @endforeach
  </ul>
  <?php $counter = 0 ;?>
  <?php if(\App\System::getCookies()=="ar"){ ?>
    <div class="tab-content text-right" style="padding-top: 20px">
            <?php }  elseif(\App\System::getCookies()=="en"){ ?> 
              <div class="tab-content text-left" style="padding-top: 20px">
                <?php } ?>
  
                                @foreach ($getclassesmain as $key => $getclassesmaindata)
    <div id="cat{{ $getclassesmaindata['id'] }}" class="tab-pane fade in @if ($counter == 0) active @endif">
    
      <div class="clearfix"></div>
      <div>
          @foreach ($getclassesmaindata["archivedata"]  as $key => $archivedata)
           
                
			
				
<!--//Start backend to retrieve variables  -->

<?php

$classid = $archivedata["class"];
$path = $archivedata["path"];
$name = $archivedata["name"];
$title = $archivedata["title"];
                       
                        ?>
<!--//End backend to retrieve variables  -->

                
            	
                <!--News Block-->
                <?php if(\App\System::getCookies()=="ar"){ ?>
                                            <div><a href='https://{{ $path."/".$name }}' style="font-size: 14px;" target="_blank"><i class="fa fa-download" style="margin-left: 10px;"></i> {{ $title }} </a></div>
                                            <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
       <div><a href='https://{{ $path."/".$name }}' style="font-size: 14px;" target="_blank"><i class="fa fa-download" style="margin-right: 10px;"></i> {{ $title }} </a></div>
                                            <?php } ?>

                
  

    @endforeach	
    </div>
                                <?php $counter++;?>
    
  </div>
  @endforeach
</div>









