import { TestBed } from '@angular/core/testing';

import { FestApiService } from './fest-api.service';

describe('FestMainService', () => {
  let service: FestApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FestApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
