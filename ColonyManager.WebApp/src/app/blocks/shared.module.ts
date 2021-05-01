import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SpinnerPopupComponent } from './spinner-popup/spinner-popup.component';
import { MaterialModule } from '../material.module';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [SpinnerPopupComponent],
  imports: [CommonModule, MaterialModule, RouterModule],
  exports: [SpinnerPopupComponent, MaterialModule, RouterModule],
})
export class SharedModule {}
