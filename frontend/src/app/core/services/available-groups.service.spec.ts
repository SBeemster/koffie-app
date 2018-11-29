import { TestBed, inject } from '@angular/core/testing';
import { AvailableGroupsService } from './Available-groups.service';

describe('AvailableGroupsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AvailableGroupsService]
    });
  });

  it('should be created', inject([AvailableGroupsService], (service: AvailableGroupsService) => {
    expect(service).toBeTruthy();
  }));
});
