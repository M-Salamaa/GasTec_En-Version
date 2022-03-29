<select id="getarea">
                                                <option>{{ \App\System::getFinalText('Area') }}</option>
                                                @foreach ($areas as $area)
                                                <?php if(\App\System::getCookies()=="en"){ ?>
                                                    <option value='{{ $area["catid"] }}'>{{ $area["catname"] }}</option>
                                                    <?php } ?>
                                                    <?php if(\App\System::getCookies()=="ar"){ ?>

                                                        <option value='{{ $area["catid"] }}'>{{ $area["catname_ar"] }}</option>
                                                        <?php } ?>
                                                @endforeach
                                            </select>
                                            <input type="hidden" id="areaname" name="area" >
                                      


 <script>
               $("#getarea").click(function () {
                $("#areaname").val($("#getarea option:selected").text());

                $.ajax({
                    url: "{{ env('APP_URL') }}getformnearestst",
                    type: "post",
                    data: "_token={{ csrf_token() }}&stationid=" + $("#getarea").val(),
                    success: function (htmlinner) {
                     
                            $("#getstations").html(htmlinner);
                        
                    }
                });
            });
               </script>