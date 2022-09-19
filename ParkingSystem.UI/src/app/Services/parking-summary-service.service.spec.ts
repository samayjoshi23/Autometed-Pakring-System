import { TestBed } from '@angular/core/testing';

import { ParkingSummaryServiceService } from './parking-summary-service.service';

describe('ParkingSummaryServiceService', () => {
  let service: ParkingSummaryServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ParkingSummaryServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
