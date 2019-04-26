//var myApp = angular.module('MyApp') // Login Controller
var myApp = angular.module("MyApp", []);

myApp.controller('LoginController', function ($scope, LoginService) {
    $scope.IsLogedIn = false;
    $scope.Message = '';
    $scope.Submitted = false;
    $scope.IsFormValid = false;
    
    $scope.LoginData = {
        Username: '',
        Password: ''
    };

    //Check is Form Valid or Not // Here f1 is our form Name
    $scope.$watch('f1.$valid', function (newVal) {
        $scope.IsFormValid = newVal;
    });
    
    $scope.Login = function () {        
        $scope.Submitted = true;
        if ($scope.IsFormValid) {
            LoginService.GetUser($scope.LoginData).then(function (d) {
                
                if (d.data.UserName != null) {
                    $scope.IsLogedIn = true;
                    $scope.Message = "Successfully login done. Welcome " + d.data.UserName;
                    if(d.data.CompanyID == 0)
                        window.location = "/User/Index";
                    else
                        window.location = "/User/ComIndex";
                }
                else {
                    alert('Invalid Credential!');
                }
            });
        }
    };

})
.factory('LoginService', function ($http) {
    var fac = {};
    fac.GetUser = function (d) {
        return $http({
            url: '/User/UserLogin',
            method: 'POST',
            data: JSON.stringify(d),
            headers: {'content-type':'application/json'}
        });
    };
    return fac;
});