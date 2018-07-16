Vue.component('collections',
    {
        template: '#collections',
        props: ['Collections'],
        data: function () {
            return {
            }
        },
        methods: {
            selectCollection: function (collection) {
                this.unselectAllCollections();
                collection.IsSelected = true;
            },
            unselectAllCollections: function () {
                var collections = this.Collections;
                for (var i = 0; i < collections.length; i++) {
                    collections[i].IsSelected = false;
                }
            }
        }
    });