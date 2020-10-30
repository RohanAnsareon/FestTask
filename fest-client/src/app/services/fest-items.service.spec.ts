import { TestBed } from '@angular/core/testing';

import { FestItemsService } from './fest-items.service';

describe('FestItemsService', () => {
  let service: FestItemsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FestItemsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
