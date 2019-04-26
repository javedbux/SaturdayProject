
var demoApp = angular.module("DemoApp", []);



demoApp.controller('myController', function ($scope, ContactService) { //inject ContactService
    
    $scope.Contact = null;
    ContactService.GetCompanyDetails().then(function (d) {
        $scope.Contact = d.data; // Success
        // $scope.namedemo = d.data.name;
    }, function () {
        alert('Failed'); // Failed
    });
})
.factory('ContactService', function ($http) { // here I have created a factory which is a populer way to create and configure services

    var fac = {};
    fac.GetCompanyDetails = function () {

        return $http.get('/CompanyMaster/GetCompanyDetails');
    }
    return fac;
});

//var information = {
//    items: []

//};

//demoApp.run(function ($http) {

//    $http.get('@Url.Action("GetAllCompanies", "CompanyMaster")').success(function (data) {
//        //alert(data);
//        angular.forEach(data, function (event, key) {

//            //information.items.push({ PageLogo: event.PageLogo, Code: event.Code, Name: event.Name, Email: event.Email, HRMPlan: event.HRMPlan, StartDate: event.StartDate, EndDate: event.EndDate, CompanyID: Eve.CompanyID });
//            information.items.push({ PageLogo: event.PageLogo, Code: event.Code, Name: event.Name, Email: event.Email, HRMPlan: event.HRMPlan, CompanyID: event.CompanyID });
//            //alert(event.Name);
//        });
//    });

//});
//demoApp.controller("myController", function ($scope) {

//    // $scope.EmployeeName = information.Name;
//    $scope.items = information.items;
//});