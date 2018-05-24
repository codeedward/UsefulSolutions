Vue.component('shopping-list',
    {
        template: '#shopping-list-componennt',
        data: function () {
            return {
                viewStep: 1, // 1-initial, 2-edit
                editedProductId: null,
                shoppingList: []
            }
        },
        methods: {
            addProduct: function () {
                var self = this;
                var newProduct =  {
                    description: "new item", quantity: 1, price: 1
                };
                $.post('/VueTest/SaveProduct', newProduct).done(function (data) {
                    self.getProducts();
                });
            },
            editProduct: function (productId) {
                this.editedProductId = productId;
                console.log(this.editedProductId);
                this.viewStep = 2;
            },
            deleteProduct: function (product) {
                var self = this;
                console.log(product.id);
                var request = { productId: product.id };
                $.post('/VueTest/DeleteProduct', request).done(function (data) {
                    self.getProducts();
                });
            },
            getProducts: function () {
                var self = this;
                $.get('/VueTest/GetProducts').done(function (data) {
                    self.shoppingList = data;
                });
            },
            setInitialState: function () {
                console.log("we are in setInitialState");
                this.viewStep = 1;
            }
        },
        mounted: function () {
            this.getProducts();
        },
        computed: {
            overallPrice: function() {
                var price = 0;
                
                for (var i = 0; i < this.shoppingList.length; i++) {
                    var product = this.shoppingList[i];
                    price += (product.quantity * product.price);
                }

                return price;
            }
        }
    })