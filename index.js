var app = angular.module('TestAngular', ['ui.router', 'ui.bootstrap']);
// app.config(function($routeProvider, $locationProvider) {
//     $routeProvider.when('/default', {
//         templateUrl: 'testpage.html',
//         controller: 'testpageCtrl'
//     }).when('/reg', {
//         templateUrl: 'app/testreg/testreg.html',
//         controller: 'testregctrl'
//     });

//     $routeProvider.otherwise({
//         templateUrl: 'app/testreg/testreg.html',
//         controller: 'testregctrl'
//     });

//     $locationProvider.html5Mode(true);

// });


app.config(function($stateProvider, $locationProvider, $urlRouterProvider) {

    $stateProvider.state({
        name: 'default',
        url: '/',
        views: {
            "topbar@": {
                templateUrl: 'templates/top.html'
            },
            "midB@": {
                templateUrl: 'app/testreg/testreg.html',
                controller: 'testregctrl',
            },
            "bottompanel@": {
                templateUrl: 'templates/bottom.html'
            }
        }
    }).state({
        name: 'kk',
        url: '/kk',
        views: {
            "topbar@": {
                templateUrl: 'templates/top.html'
            },
            "midB@": {
                templateUrl: 'testpage.html',
                controller: 'testpageCtrl',
            },
            "bottompanel@": {
                templateUrl: 'templates/bottom.html'
            }
        }
    });

    $locationProvider.html5Mode(true);
});

app.run(function($rootScope) {
    $rootScope.color = "gray";
});