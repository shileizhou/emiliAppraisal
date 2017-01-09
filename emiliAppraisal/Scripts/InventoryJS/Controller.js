app.controller('InventoryController', function ($scope, $http) {

    $scope.person = "Andy Zhou" ;

    $http({
        method: 'Get',
        url: 'http://localhost:63323/inventory'
    }).success(function (data, status) {
        $scope.subscriber = data;
    }).error(function (data, status) {
        $scope.subscriber = { CMHCNO: 00000000, APIDSTMP: "error happened", ReferralStatus: status, Borrower: "Tester" }
    });

    //getAll();

    //function getAll() {
    //    var servCall = InventoryService.getSubs();
    //    servCall.then(function (d) {
    //        $scope.subscriber = d.data;
    //    }, function (error) {
    //        $log.error('Oops! Something went wrong while fetching the data.');
    //    })
    //}
})