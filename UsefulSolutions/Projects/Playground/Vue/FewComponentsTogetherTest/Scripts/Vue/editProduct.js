Vue.component('edit-product', {
    template: '#edit-product-component',
    props: ['productId'],
    data: function() {
        return {
            product: {}
        }
    },
    methods: {
        getProduct: function () {
            var self = this;
            $.get('/VueTest/GetProduct/' + this.productId).done(function (data) {
                console.log(data);
                self.product = data;
            });
        },
        saveProduct: function () {
            var self = this;
            var request = this.product;
            $.post('/VueTest/SaveProduct/', request).done(function (data) {
                console.log("product saved:" + data);
                self.$emit('set-initial-state');
            });
        }  
    },
    mounted: function() {
        this.getProduct();
    }
});