Vue.component('form-builder',
    {
        template: '#form-builder',
        props: ['model'],
        data: function () {
            return {
                selectedCollection: null
            }
        },
        methods: {
            selectCollection: function (collection) {
                this.selectedCollection = collection;
            }
        },
        computed: {
            //selectedCollection2: function() {
            //    if (this.selectedCollection) {
            //        console.log("test3");
            //        return this.selectedCollection;
            //    }
            //    return {};
            //}
        },
        updated: function () {
            //if (this.model.Collections) {
            //    return this.selectedCollection = this.model.Collections[0];
            //}
        }
    });