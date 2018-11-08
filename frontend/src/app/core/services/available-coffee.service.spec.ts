import { TestBed, inject } from "@angular/core/testing";

import { AvailableCoffeeService } from "./Available-coffee.service";

describe("AvailableCoffeeService", () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AvailableCoffeeService]
    });
  });

  it("should be created", inject(
    [AvailableCoffeeService],
    (service: AvailableCoffeeService) => {
      expect(service).toBeTruthy();
    }
  ));

  it("should be de same as count from API GET methode", () => {
    //TODO code aanpassen voor test API
    const result = AvailableCoffeeService;
    expect(result).not.toBeNull();
  });
});
