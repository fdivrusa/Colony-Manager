import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PeoplesComponent } from './peoples.component';
import { SharedModule } from 'src/app/blocks/shared.module';
import { PeoplesRoutingModule } from './peoples-routing.module';
import { PeopleDetailsComponent } from './people-details/people-details.component';
import { PeoplesContactsComponent } from './peoples-contacts/peoples-contacts.component';
import { PeoplesAddressesComponent } from './peoples-addresses/peoples-addresses.component';
import { PeoplesAttributionsComponent } from './peoples-attributions/peoples-attributions.component';

@NgModule({
  declarations: [
    PeoplesComponent,
    PeopleDetailsComponent,
    PeoplesContactsComponent,
    PeoplesAddressesComponent,
    PeoplesAttributionsComponent,
  ],
  imports: [SharedModule, CommonModule, PeoplesRoutingModule],
})
export class PeoplesModule {}
