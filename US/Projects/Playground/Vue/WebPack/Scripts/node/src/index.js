import _ from 'lodash';
import * as hello from './hello.js'

function component() {
    var element = document.createElement('div');

    // Lodash, currently included via a script, is required for this line to work
    element.innerHTML = _.join(['Hello2', 'webpack'], ' ');
    hello.sayHello();

    return element;
}

document.body.appendChild(component());