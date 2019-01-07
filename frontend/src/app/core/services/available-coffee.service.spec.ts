import { TestBed, inject, async } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { HttpClientModule, } from '@angular/common/http';
import { RouterTestingModule } from '@angular/router/testing';
import { AvailableCoffeeService } from './Available-coffee.service';


describe('AvailableCoffeeService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpClientModule, HttpClientTestingModule, RouterTestingModule
      ],
      providers: [AvailableCoffeeService]
    });
  });

  it('should be created', inject(
    [AvailableCoffeeService],
    (service: AvailableCoffeeService) => {
      expect(service).toBeTruthy();
    }
  ));

  it('get coffee shouldnt be empty or null', async(inject(
    [AvailableCoffeeService],
    (service: AvailableCoffeeService) => {
      const result = service.getCoffee();
      expect(service.getCoffee).not.toBe('');
      expect(service.getCoffee).not.toBeNull();

    })));

  it('should be a get method', async(inject(
    [AvailableCoffeeService],
    (service: AvailableCoffeeService) => {
      expect(service.getCoffee()).toContain('GET');
    })));
});
