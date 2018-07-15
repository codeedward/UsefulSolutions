Vue.component('collections',
    {
        template: '#collections',
        props: ['Collections','parent'],
        data: function () {
            return {
            }
        },
        methods: {
            selectCollection: function(collection) {
                this.parent.selectCollection(collection);
            }
        },
        mounted: function () {
            var self = this;
            setTimeout(function() {
                    self.selectCollection(self.Collections[0]);
                },
                2000);

        }
    });