Vue.component('shopping-list',
    {
        template: '#shopping-list-componennt',
        data: function () {
            return {
                viewStep: 1,
                shoppingList: [
                    { description: "eggs", quantity: 1, price: 2 },
                    { description: "cashews", quantity: 2, price: 10 }
                ] 
            }
        },
        methods: {
            addProduct: function() {
                this.shoppingList.push({
                    description: "new item", quantity: 1, price: 1
                });
            },
            editProduct: function() {

            },
            deleteProduct: function () {

            }
        }

    })