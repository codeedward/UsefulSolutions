Vue.component('login',
    {
        template: '#login-componennt',
        data: function() {
            return {
                login: '',
                loginPlaceholder: 'login',
                password: '',
                passwordPlaceholder: 'password'
            }
        },
        methods: {
            logIn: function() {
                app.viewStep = 2;
            }
        }

    })