import { Component, OnInit, AfterViewInit } from '@angular/core';
import { delay } from 'rxjs/operators';
import { LoaderService } from 'src/app/services/loader.service';

@Component({
  selector: 'app-spinner-popup',
  templateUrl: './spinner-popup.component.html',
  styleUrls: ['./spinner-popup.component.scss'],
})
export class SpinnerPopupComponent implements AfterViewInit {
  mode = 'intermediate';
  value = 50;
  isLoading: boolean = false;

  constructor(private loaderService: LoaderService) {
    console.log('GNEEEEE');
  }

  ngAfterViewInit() {
    setTimeout(() => {
      this.loaderService.isLoading.pipe(delay(0)).subscribe((res) => {
        setTimeout(() => {
          this.isLoading = res;
        }, 0.1);
      });
    });
  }
}
