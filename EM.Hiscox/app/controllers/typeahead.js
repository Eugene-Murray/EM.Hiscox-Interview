'use strict';


angular.module('angularApp')
  .controller('TypeAheadController', function ($scope, $http) {


      // TODO: put in to a service.js and do a get request on GetSations(string searchTerm)
      $http({ method: "GET", url: "api/Stations/GetAll" })
        .success(function (result) {
            $scope.stations = result;
        })
        .error(function (data) {
            console.error(data);
        });



      
  });
