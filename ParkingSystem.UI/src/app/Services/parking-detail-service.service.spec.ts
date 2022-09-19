import { TestBed } from '@angular/core/testing';

import { ParkingDetailServiceService } from './parking-detail-service.service';

describe('ParkingDetailServiceService', () => {
  let service: ParkingDetailServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ParkingDetailServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
