Vue.component('collections',
    {
        template: '#collections',
        props: ['Collections'],
        data: function () {
            return {
               collectionSelected: 1
            }
        },
        methods: {
            selectCollection: function(collectionId) {
                this.collectionSelected = collectionId;
            }
        }
    });