<div class="panel-group" id="accordion">
     <?php foreach($careers as $key=>$career){
                                       

                                        ?>
                                                                        <div class="panel panel-default">
                                    <div class="panel-heading">
                                    <?php if(\App\System::getCookies()=="ar"){ ?>
                                       <a data-toggle="collapse" data-parent="#accordion" href="#collapse-<?=$key;?>" class="collapsed"> <h4 class="panel-title"><?php echo $career["node"]->attributes()->vacancy ?><span class="btn btn-default btn-xs pull-left" style="margin-left:20px">إنتهاء <?php echo $career["node"]->attributes()->edate ?></span></h4></a>
                                    <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
        <a data-toggle="collapse" data-parent="#accordion" href="#collapse-<?=$key;?>" class="collapsed"> <h4 class="panel-title"><?php echo $career["node"]->attributes()->second_vacancy ?><span class="btn btn-default btn-xs pull-right" style="margin-left:20px">Expire <?php echo $career["node"]->attributes()->edate ?></span></h4></a>
        <?php } ?>                                
    </div>
                                    <div class="panel-collapse collapse" id="collapse-<?=$key;?>" style="height: 0px;">
                                        <div class="panel-body">
                                        <h5 class="text-info">{{ \App\System::getFinalText('Vacancy Details') }}</h5>
                                        <?php if(\App\System::getCookies()=="ar"){ ?>
                                            <p> <?php echo $career["node"]->attributes()->description ?> </p>
                                            <?php } elseif(\App\System::getCookies()=="en"){ ?> 
                                                <p> <?php echo $career["node"]->attributes()->second_description ?> </p>
<?php } ?>  
                                            <h5 class="text-info">{{ \App\System::getFinalText('Vacancy Requirements') }}</h5>
                                            <div class="row">
                                                <?php foreach($career["node2"]as $specs){ ?>
                                                <div class="col-md-6 pull-right" dir="rtl"><b><?php echo $specs->attributes()->name ?> : <?php echo $specs->attributes()->value ?></b></div>
                                                <?php } ?> 
                                            <div class="col-md-12">
                                                 <div class="clearfix"></div>
                                             <hr>
                                             <button onclick="changename('<?php echo $career["node"]->attributes()->vacancy ?>');" class="btn btn-sm btn-primary quotation pull-right">{{ \App\System::getFinalText('Apply') }}</button></div>
                                             </div>
                                        </div>
                                    </div>
                                </div>
                                                                        <?php } ?>
                                                                    </div>
    
    
    
    
    <div class="row">
        <div class="gap-small"></div>
                        <div class="col-md-12 information-entry">
                        
                            <form method="post" enctype="multipart/form-data" > 
                            <input type="hidden" name="_token" value="{{csrf_token()}}">  
                                    <div class="row">
                                        <div class="col-sm-12">
                                            <h3 class="block-title size-4" >{{ \App\System::getFinalText('Apply Vacancy') }}</h3>
                                            <br>
                                        </div>
                                        
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                            <label>{{ \App\System::getFinalText('Full Name') }} <span style="font-size:20px; color:red">*</span></label>
                                            <input name="Name" class="form-control" type="text" placeholder="{{ \App\System::getFinalText('Full Name') }}" required value="" />
                                            <div class="clear"></div>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                            <label>{{ \App\System::getFinalText('Address') }}<span style="font-size:20px; color:red">*</span></label>
                                            <input name="adress" class="form-control" type="text" placeholder="{{ \App\System::getFinalText('Address') }}" value="" />
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                            <label>{{ \App\System::getFinalText('Email Address') }} <span style="font-size:20px; color:red">*</span></label>
                                            <input name="Email" class="form-control" type="email" placeholder="{{ \App\System::getFinalText('Email Address') }}" required value="" />
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                            <label>{{ \App\System::getFinalText('Phone Number') }}<span style="font-size:20px; color:red">*</span></label>
                                            <input name="UserPhone" class="form-control" type="text" placeholder="{{ \App\System::getFinalText('Phone Number') }}" required value="" />
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                        <label>{{ \App\System::getFinalText('Vacancy') }}<span style="font-size:20px; color:red">*</span></label>
                                        <input type="text" class="form-control" placeholder="{{ \App\System::getFinalText('Vacancy') }}" id="vacnameinput" value="" name="vacname" readonly required/>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            
                                            <div class="form-group">
                                            <label>{{ \App\System::getFinalText('Upload your CV (Max Size:2M)') }}<span style="font-size:20px; color:red">*</span></label>
                                    <input type="file" name="upfile2"   class="form-control" required=""/>
                                            </div>
                                            
                                        </div>
                                        <div class="col-md-12">
                                        <?php if(\App\System::getCookies()=="ar"){ ?>
                                        <input name="send" class="theme-btn btn-style-one pull-right" type="submit" value="إرسل طلب" />
                                        <?php } 
       
       elseif(\App\System::getCookies()=="en"){ ?> 
       <input name="send" class="theme-btn btn-style-one" type="submit" value="Send" />
       <?php } ?>
                                    </div>
                                    </div>
                                </form>
                           
                       
                        </div>
                        
                        
                    </div>
<script>

function changename(vacancyname){
    
    
    $("#vacnameinput").val(vacancyname);
}

</script>