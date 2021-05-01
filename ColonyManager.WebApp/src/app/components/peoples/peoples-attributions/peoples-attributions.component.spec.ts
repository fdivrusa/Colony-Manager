import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PeoplesAttributionsComponent } from './peoples-attributions.component';

describe('PeoplesAttributionsComponent', () => {
  let component: PeoplesAttributionsComponent;
  let fixture: ComponentFixture<PeoplesAttributionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PeoplesAttributionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PeoplesAttributionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
