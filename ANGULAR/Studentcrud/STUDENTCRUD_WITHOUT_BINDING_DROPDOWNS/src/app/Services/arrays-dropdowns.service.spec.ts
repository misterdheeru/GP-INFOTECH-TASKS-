import { TestBed } from '@angular/core/testing';

import { ArraysDropdownsService } from './arrays-dropdowns.service';

describe('ArraysDropdownsService', () => {
  let service: ArraysDropdownsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ArraysDropdownsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
