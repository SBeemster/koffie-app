import { TestBed, inject } from '@angular/core/testing';

import { AvailableCoffeeService } from './available-coffee.service';

describe('AvailableCoffeeService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AvailableCoffeeService]
    });
  });

  it('should be created', inject([AvailableCoffeeService], (service: AvailableCoffeeService) => {
    expect(service).toBeTruthy();
  }));
});
