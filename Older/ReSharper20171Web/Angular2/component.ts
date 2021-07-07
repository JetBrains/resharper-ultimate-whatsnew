import { Component, Input } from '@angular/core';

@Component({
    selector: 'my-component',
    template: `<div [style.font-size]="mediumFont ? 'medium' : 'small'" >{{title}}</div>`
})
class AppComponent2 {
    @Input()
    title = 'Default title';
    @Input('important')
    mediumFont = false;
    boo = 5;
}