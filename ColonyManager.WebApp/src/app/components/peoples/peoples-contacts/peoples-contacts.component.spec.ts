import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PeoplesContactsComponent } from './peoples-contacts.component';

describe('PeoplesContactsComponent', () => {
  let component: PeoplesContactsComponent;
  let fixture: ComponentFixture<PeoplesContactsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PeoplesContactsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PeoplesContactsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
