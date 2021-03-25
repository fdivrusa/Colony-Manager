import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SpinnerPopupComponent } from './spinner-popup/spinner-popup.component';
import { MaterialModule } from '../material.module';
import { NotificationPopupComponent } from './notification-popup/notification-popup.component';

@NgModule({
  declarations: [SpinnerPopupComponent, NotificationPopupComponent],
  imports: [CommonModule, MaterialModule],
  exports: [SpinnerPopupComponent, MaterialModule],
})
export class SharedModule {}
