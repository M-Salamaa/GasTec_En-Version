<div class="sidebar-widget sidebar-blog-category">
                            <ul class="blog-cat">
                              
                              @foreach ($linkslist->node as $linkdata)
                              <?php
                              $linkimg = $linkdata->attributes()->multiimagesgroup;
$linkcms = $linkdata->attributes()->url;
$linkclass = $linkdata->attributes()->class;
$linkid = $linkdata->attributes()->id;
$linktitle = $linkdata->attributes()->title;
$linktitlesecond = $linkdata->attributes()->second_title;

                            
                                                    if($linkclass=="32693"){
                                                        $linkfullurl = env('APP_URL')."aboutus/";
                                                    }
                                                    elseif($linkclass=="32695"){
                                                        $linkfullurl = env('APP_URL')."car_conversion/";
                                                    }
                                                    elseif($linkclass=="32696"){
                                                        $linkfullurl = env('APP_URL')."stations/";
                                                    }
                                                    elseif($linkclass=="32697"){
                                                        $linkfullurl = env('APP_URL')."cylinder_test/";
                                                    }
                                                    elseif($linkclass=="32698"){
                                                        $linkfullurl = env('APP_URL')."oil_distribution/";
                                                    }
                                                    elseif($linkclass=="32699"){
                                                        $linkfullurl = env('APP_URL')."statistics/";
                                                    }
                                                    elseif($linkclass=="32694"){
                                                        $linkfullurl = env('APP_URL')."hr/";
                                                    }
                                                    ?>

<?php if(\App\System::getCookies()=="ar"){ ?>
                                <li <?php  if($getlinkid==$linkid){ ?> class="active" <?php } ?>><a href="{{ $linkfullurl.$linkid }}">{{ $linktitle }}</a></li>
                                <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>

                                <li <?php  if($getlinkid==$linkid){ ?> class="active" <?php } ?>><a href="{{ $linkfullurl.$linkid }}">{{ $linktitlesecond }}</a></li>
       <?php } ?>
                       @endforeach
					   
					    @if ($linkclass == 32693)

                        <?php if(\App\System::getCookies()=="ar"){ ?>
                       <li <?php  if($getlinkid==$linkid){ ?> class="active" <?php } ?>><a href="{{ env('APP_URL').'hr/1601' }}">الموارد البشرية</a></li>
                       <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?>
                       <li <?php  if($getlinkid==$linkid){ ?> class="active" <?php } ?>><a href="{{ env('APP_URL').'hr/1601' }}">HR</a></li>
                       <?php } ?>
                     
                     @endif
                            </ul>
                        </div>