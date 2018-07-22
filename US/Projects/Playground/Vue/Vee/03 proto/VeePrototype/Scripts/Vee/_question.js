Vue.component('question',
    {
        template: '#question',
        props: ['Question'],
        data: function () {
            return {
            }
        },
        created: function () {
            var vm = this;
            bus.$on('validate_all', function () {
                vm.$validator.validateAll();
            });
        }
    });