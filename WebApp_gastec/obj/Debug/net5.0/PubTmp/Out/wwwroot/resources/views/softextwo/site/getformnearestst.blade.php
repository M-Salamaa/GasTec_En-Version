

                                            <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                    <select name="nearests">
                                                <option>{{ \App\System::getFinalText('Nearest Station') }}</option>
                                                @foreach ($stations as $station)
                                                <?php if(\App\System::getCookies()=="en"){ ?>
                                                <option value='{{ $station["itemname"] }}'>{{ $station["itemname"] }}</option>
                                                <?php } ?>
                                                <?php if(\App\System::getCookies()=="ar"){ ?>
                                                <option value='{{ $station["itemname_ar"] }}'>{{ $station["itemname_ar"] }}</option>
                                                <?php } ?>
                                                @endforeach
                                            </select>
                                    </div>
                                    
                                    <div class="form-group col-md-6 col-sm-6 col-xs-12">
                                    <select name="nearestc">

                                                <option>{{ \App\System::getFinalText('Nearest Conversion Station') }}</option>

                                               @foreach ($stationsconv as $station)
                                               <?php if(\App\System::getCookies()=="en"){ ?>
                                                <option value='{{ $station["itemname"] }}'>{{ $station["itemname"] }}</option>
                                                <?php } ?>
                                                <?php if(\App\System::getCookies()=="ar"){ ?>
                                                <option value='{{ $station["itemname_ar"] }}'>{{ $station["itemname_ar"] }}</option>
                                                <?php } ?>
                                                @endforeach
                                            
                                               
                                            </select>
                                    </div>


 