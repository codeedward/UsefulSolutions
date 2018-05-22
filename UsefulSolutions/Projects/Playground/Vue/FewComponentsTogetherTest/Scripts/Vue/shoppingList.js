Vue.component('shopping-list',
    {
        template: '#shopping-list-componennt',
        data: function () {
            return {
                viewStep: 1,
                shoppingList: []
            }
        },
        methods: {
            addProduct: function () {
                var self = this;
                var newProduct =  {
                    description: "new item", quantity: 1, price: 1
                };
                $.post('/VueTest/AddProduct', newProduct).done(function (data) {
                    console.log(data);
                    self.getProducts();
                });
            },
            editProduct: function () {

            },
            deleteProduct: function (product) {
                var self = this;
                console.log(product.id);
                var request = { productId: product.id };
                $.post('/VueTest/DeleteProduct', request).done(function (data) {
                    console.log(data);
                    self.getProducts();
                });
            },
            getProducts: function () {
                var self = this;
                $.get('/VueTest/GetProducts').done(function (data) {
                    console.log(data);
                    self.shoppingList = data;
                });
            }
        },
        mounted: function () {
            this.getProducts();
        }
    })