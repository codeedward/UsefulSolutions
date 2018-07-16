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
            },
            selectedPage: function () {
                var result = {}
                var collection = this.selectedCollection;
                if (collection) {
                    var pages = collection.Pages;
                    if (pages) {
                        for (var i = 0; i < pages.length; i++) {
                            if (pages[i].IsSelected) {
                                result = pages[i];
                                break;
                            }
                        }
                    }
                }
                return result;
            }
        }
    });