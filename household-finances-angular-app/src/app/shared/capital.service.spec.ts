import { TestBed } from '@angular/core/testing';

import { CapitalService } from './capital.service';

describe('CapitalService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CapitalService = TestBed.get(CapitalService);
    expect(service).toBeTruthy();
  });
});
