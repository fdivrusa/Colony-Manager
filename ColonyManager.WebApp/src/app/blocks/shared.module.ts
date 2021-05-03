import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SpinnerPopupComponent } from './spinner-popup/spinner-popup.component';
import { MaterialModule } from '../material.module';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

@NgModule({
  declarations: [SpinnerPopupComponent],
  imports: [CommonModule, MaterialModule, RouterModule, FontAwesomeModule],
  exports: [
    SpinnerPopupComponent,
    MaterialModule,
    RouterModule,
    FontAwesomeModule,
  ],
})
export class SharedModule {}
