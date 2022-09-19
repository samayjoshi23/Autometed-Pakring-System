import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParkingSummaryComponent } from './parking-summary.component';

describe('ParkingSummaryComponent', () => {
  let component: ParkingSummaryComponent;
  let fixture: ComponentFixture<ParkingSummaryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ParkingSummaryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ParkingSummaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
