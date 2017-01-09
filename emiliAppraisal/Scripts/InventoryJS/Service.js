app.service("InventoryService", function ($http) {

    this.getSubs = function () {
        return $http.get("http://localhost:63323/inventory");
    }
});