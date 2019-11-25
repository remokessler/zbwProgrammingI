import Vue from 'vue';
import Component from 'vue-class-component';

@Component({
  template: './my-first-component.html'
})
export default class MyFirstComponent extends Vue {
  val1: number = 0;
  val2: number = 0;
  result: string = '';

  setResult(): void {
    if(this.val1 > this.val2) {
      this.result = '>';
    } else if(this.val1 < this.val2) {
      this.result = '<';
    } else if(this.val1 == this.val2) {
      this.result = '=';
    }
  }
}