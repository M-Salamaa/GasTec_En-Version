@extends(env('TEMPLATE').'.layouts.mainadminint')
@section('content')

<!-- DataTales Example -->
<div class="card shadow mb-4">
    <div class="card-header py-3">
        <h6 class="m-0 font-weight-bold text-primary">Locations</h6>
    </div>
    <div class="card-body">
        <div class="table-responsive">
            <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Name</th>
                    </tr>
                </thead>
            
                <tbody>
                    
                    <tr>
                    <td>1</td>
                        <td><a href="{{ env('APP_URL') }}editmap/1">Convert Centers</a></td>
                    </tr>
                    <tr>
                    <td>2</td>
                        <td><a href="{{ env('APP_URL') }}editmap/2">Cylinder Test</a></td>
                    </tr>
                    <tr>
                    <td>3</td>
                        <td><a href="{{ env('APP_URL') }}editmap/3">Gas Station</a></td>
                    </tr>
                    <tr>
                    <td>4</td>
                        <td><a href="{{ env('APP_URL') }}editmap/4">Oil Distribution</a></td>
                    </tr>
                    <tr>
                        <td>5</td>
                        <td><a href="{{ env('APP_URL') }}editmap/5">Petrol Station</a></td>
                    </tr>
                </tbody>
            </table>



            <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>الإسم</th>
                    </tr>
                </thead>
            
                <tbody>
                    
                    <tr>
                    <td>1</td>
                        <td><a href="{{ env('APP_URL') }}editmap/6">مراكز تحويل السيارات</a></td>
                    </tr>
                    <tr>
                    <td>2</td>
                        <td><a href="{{ env('APP_URL') }}editmap/7">مراكز اختبار الإسطوانات</a></td>
                    </tr>
                    <tr>
                    <td>3</td>
                        <td><a href="{{ env('APP_URL') }}editmap/8">محطات الغاز</a></td>
                    </tr>
                    <tr>
                    <td>4</td>
                        <td><a href="{{ env('APP_URL') }}editmap/9">مراكز توزيع الزيوت</a></td>
                    </tr>
                    <tr>
                        <td>5</td>
                        <td><a href="{{ env('APP_URL') }}editmap/10">محطات البنزين</a></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>


    @endsection