'use strict';


angular
  .module('angularApp', [
    'ngAnimate',
    'ngCookies',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch',
    'kendo.directives'
  ])
  .config(function ($routeProvider) {

    $routeProvider
      .when('/', {
        templateUrl: 'app/views/main.html',
        controller: 'MainController'
      })
      .when('/typeahead', {
        templateUrl: 'app/views/typeahead.html',
        controller: 'TypeAheadController'
      })
      .otherwise({
        redirectTo: '/'
      });
  });
