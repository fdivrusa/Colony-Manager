import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PeoplesAddressesComponent } from './peoples-addresses.component';

describe('PeoplesAddressesComponent', () => {
  let component: PeoplesAddressesComponent;
  let fixture: ComponentFixture<PeoplesAddressesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PeoplesAddressesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PeoplesAddressesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
