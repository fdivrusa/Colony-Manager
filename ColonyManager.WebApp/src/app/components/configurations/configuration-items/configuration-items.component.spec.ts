import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConfigurationItemsComponent } from './configuration-items.component';

describe('ConfigurationItemsComponent', () => {
  let component: ConfigurationItemsComponent;
  let fixture: ComponentFixture<ConfigurationItemsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConfigurationItemsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ConfigurationItemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
