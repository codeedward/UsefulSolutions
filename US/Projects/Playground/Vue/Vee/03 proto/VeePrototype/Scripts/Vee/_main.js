var app = new Vue({
    el: '#app',
    data: {
        message: 'This is prototype of vee in complicated collection - pages structure',
        model: {}
    },
    methods: {
        getData: function () {
            var self = this;
            $.ajax({
                type: 'get',
                dataType: 'json',
                cache: false,
                url: '/Vee/GetData',
                //data: { keyid: 1, newval: 10 },
                success: function (data) {
                    self.model = data;

                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert('Error - ' + errorThrown);
                }
            });
        }
    },
    mounted: function() {
        this.getData();
    }
});