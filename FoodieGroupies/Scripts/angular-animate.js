angular.module('ui.bootstrap.demo', ['ngAnimate', 'ui.bootstrap']);
angular.module('ui.bootstrap.demo').controller('RatingDemoCtrl', function ($scope) {
    //These are properties of the Rating object  
    $scope.rate = 7;    //gets or sets the rating value  
    $scope.max = 10;    //displays number of icons(stars) to show in UI  
    $scope.isReadonly = false;  //prevents the user interaction if set to true.  
    $scope.hoveringOver = function (value) {
        $scope.overStar = value;
        $scope.percent = 100 * (value / $scope.max);
    };
    //Below are the rating states  
    //These are array of objects defining properties for all icons.   
    //In default template below 'stateOn&stateOff' properties are used to specify icon's class.  
    $scope.ratingStates = [
      { stateOn: 'glyphicon-ok-sign', stateOff: 'glyphicon-ok-circle' },
      { stateOn: 'glyphicon-star', stateOff: 'glyphicon-star-empty' },
      { stateOn: 'glyphicon-heart', stateOff: 'glyphicon-ban-circle' },
      { stateOn: 'glyphicon-heart' },
      { stateOff: 'glyphicon-off' }
    ];
});