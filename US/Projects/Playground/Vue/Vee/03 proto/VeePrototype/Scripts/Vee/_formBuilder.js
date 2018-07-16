Vue.component('form-builder',
    {
        template: '#form-builder',
        props: ['model'],
        data: function () {
            return {
            }
        },
        computed: {
            selectedCollection: function () {
                var result = {}
                var collections = this.model.Collections;
                if (collections) {
                    for (var i = 0; i < collections.length; i++) {
                        if (collections[i].IsSelected) {
                            result = collections[i];
                            break;
                        }
                    }
                }
                return result;
            }
        }
    });