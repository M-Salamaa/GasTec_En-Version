@extends(env('TEMPLATE').'.layouts.mainadminint')
@section('content')
<script>
function addnewlocation(){
    $("#locationslist").prepend('<div class="col-md-6"><table class="table table-bordered" id="dataTable" width="100%" cellspacing="0"> <thead style="background: #f1f1f1;"> <tr> <th>Title</th> <th>Value</th> </tr></thead> <tbody> <tr> <td>lat</td><td><input type="text" name="lat[]" class="form-control form-control-user" placeholder="lat"></td></tr><tr> <td>lng</td><td><input type="text" name="lng[]" class="form-control form-control-user" placeholder="lng"></td></tr><tr> <td>title</td><td><input type="text" name="title[]" class="form-control form-control-user" placeholder="title"></td></tr><tr> <td>street</td><td><input type="text" name="street[]" class="form-control form-control-user" placeholder="street"></td></tr><tr> <td>city</td><td><input type="text" name="city[]" class="form-control form-control-user" placeholder="city"></td></tr><tr> <td>zip</td><td><input type="text" name="zip[]" class="form-control form-control-user" placeholder="zip"></td></tr><tr> <td>city</td><td><input type="text" name="proimage[]" class="form-control form-control-user" placeholder="proimage"></td></tr><tr> <td>zip</td><td><input type="text" name="markericon[]" class="form-control form-control-user" placeholder="markericon"></td></tr></tbody> </table><input type="submit" class="btn btn-primary" value="Update" name="update" style="margin-bottom: 20px;"/></div>');
}

</script>
<!-- DataTales Example -->
<div class="card shadow mb-4">
    <div class="card-header py-3">
        <h6 class="m-0 font-weight-bold text-primary">{{$pagename}} <a href="{{ env('APP_URL') }}admin" style="float: right; font-weight:400">< Back</a></h6>
       
    </div>
    <button class="btn btn-primary" onclick="addnewlocation();">Add new location</button>
    <div class="card-body">
        <div class="table-responsive">
            <form action="" method="POST">
                <div class="row" id="locationslist">
        @foreach ($filedata as $locations)
        
        <div class="col-md-6">
    
            <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                <thead style="background: #f1f1f1;">
                    <tr>
                        <th>Title</th>
                        <th>Value</th>
                    </tr>
                </thead>
            
                <tbody>
                    
                    <tr>
                        <td>lat</td>
                        <td><input type="text" name="lat[]" value="{{ $locations['lat'] }}" class="form-control form-control-user" placeholder="lat"></td>
                    </tr>
                    <tr>
                        <td>lng</td>
                        <td><input type="text" name="lng[]" value="{{ $locations['lng'] }}" class="form-control form-control-user" placeholder="lng"></td>
                    </tr>
                    <tr>
                        <td>title</td>
                        <td><input type="text" name="title[]" value="{{ $locations['title'] }}" class="form-control form-control-user" placeholder="title"></td>
                    </tr>
                    <tr>
                        <td>street</td>
                        <td><input type="text" name="street[]" value="{{ $locations['street'] }}" class="form-control form-control-user" placeholder="street"></td>
                    </tr>
                    <tr>
                        <td>city</td>
                        <td><input type="text" name="city[]" value="{{ $locations['city'] }}" class="form-control form-control-user" placeholder="city"></td>
                    </tr>
                    <tr>
                        <td>zip</td>
                        <td><input type="text" name="zip[]" value="{{ $locations['zip'] }}" class="form-control form-control-user" placeholder="zip"></td>
                    </tr>
                    <tr>
                        <td>city</td>
                        <td><input type="text" name="proimage[]" value="{{ $locations['proimage'] }}" class="form-control form-control-user" placeholder="proimage"></td>
                    </tr>
                    <tr>
                        <td>zip</td>
                        <td><input type="text" name="markericon[]" value="{{ $locations['markericon'] }}" class="form-control form-control-user" placeholder="markericon"></td>
                    </tr>
                </tbody>
            </table>
            <input type="submit" class="btn btn-primary" value="Update" name="update" style="margin-bottom: 20px;"/>
            </div>
            
            @endforeach
            </div>
            @csrf
            
            </form>
        </div>
    </div>
</div>


    @endsection