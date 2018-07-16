Vue.component('pages-panel',
    {
        template: '#pages-panel',
        props: ['Collection'],
        data: function () {
            return {
            }
        },
        methods: {
            selectPage: function (page) {
                this.unselectAllPages();
                page.IsSelected = true;
            },
            unselectAllPages: function () {
                var pages = this.Collection.Pages;
                for (var i = 0; i < pages.length; i++) {
                    pages[i].IsSelected = false;
                }
            }
        }
    });