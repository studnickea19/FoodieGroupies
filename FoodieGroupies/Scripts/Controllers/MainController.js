starApp.controller('StarCtrl', ['$scope', function ($scope) {
    $scope.rating = 0;
    $scope.ratings = [{
        current: 0,
        max: 5
    }];

    //TEST
    $scope.getSelectedRating = function (rating) { 
        console.log(rating);
    }
}]);

starApp.directive('starRating', function () {
    return {
        restrict: 'A',
        templateUrl: '<ul class="rating">' +
            '<li ng-repeat="star in stars" ng-class="star" ng-click="toggle($index)">' +
            '\u2605' +
            '</li>' +
            '</ul>',
        scope: {
            ratingValue: '=',
            max: '=',
            onRatingSelected: '&'
        },
        link: function (scope, elem, attrs) {

            var updateStars = function () {
                scope.stars = [];
                for (var i = 0; i < scope.max; i++) {
                    scope.stars.push({
                        filled: i < scope.ratingValue
                    });
                }
            };

            scope.toggle = function (index) {
                scope.ratingValue = index + 1;
                scope.onRatingSelected({
                    rating: index + 1
                });
            };

            scope.$watch('ratingValue', function (oldVal, newVal) {
                if (newVal) {
                    updateStars();
                }
            });
        }
    };
});