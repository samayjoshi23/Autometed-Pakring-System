import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParkingRulesComponent } from './parking-rules.component';

describe('ParkingRulesComponent', () => {
  let component: ParkingRulesComponent;
  let fixture: ComponentFixture<ParkingRulesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ParkingRulesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ParkingRulesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
