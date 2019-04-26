//angular.module('MyApp') //extending from previously created angular module in the previous part
var myApp = angular.module("MyApp", []);


myApp.controller('myController', function ($scope, ContactService) { //inject ContactService

 
   
    $scope.Contact = null;
    ContactService.GetAllCompaniesAngu().then(function (d) {
        $scope.Contact = d.data; // Success
       
    }, function () {
        alert('Failed'); // Failed
    });
})
.factory('ContactService', function ($http) { // here I have created a factory which is a populer way to create and configure services
    var fac = {};
    fac.GetAllCompaniesAngu = function () {
       
        return $http.get('/CompanyMaster/GetAllCompaniesAngu');
    }
    return fac;
});


