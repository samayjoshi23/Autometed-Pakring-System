import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UnparkVehicleComponent } from './unpark-vehicle.component';

describe('UnparkVehicleComponent', () => {
  let component: UnparkVehicleComponent;
  let fixture: ComponentFixture<UnparkVehicleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UnparkVehicleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UnparkVehicleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
