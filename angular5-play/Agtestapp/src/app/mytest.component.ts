import { Component, Input } from '@angular/core'

@Component({
    selector: 'mytest',
    templateUrl: 'mytest.component.html',
    styles: [`
        .glyphicon-thumbs-down {
            color: red;
        }
        .glyphicon-star {
            color: orange;
        }

    `]
})
export class MyTestComponent{
    @Input() myValue = 'What do you think?';
    @Input() myOtherValue = 'Boo 2';

    onClick(value){
        this.myValue = value;
    }
}