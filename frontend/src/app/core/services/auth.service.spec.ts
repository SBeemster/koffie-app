import { TestBed, inject, async } from '@angular/core/testing';
import { AuthService } from './auth.service';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { HttpClientModule, } from '@angular/common/http';
import { RouterTestingModule } from '@angular/router/testing';

describe('AuthService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpClientModule, HttpClientTestingModule, RouterTestingModule
      ],
      providers: [AuthService]
    });
  });

  it('should be created', async(inject([HttpTestingController, AuthService], (httpClient: HttpTestingController, service: AuthService) => {
    expect(service).toBeTruthy();
  })));

  it('should have a login function', inject([AuthService], (service: AuthService) => {
    expect(service.login).toBeTruthy();
  }));

  it('should have a logout function', inject([AuthService], (service: AuthService) => {
    expect(service.logout).toBeTruthy();
  }));

  it('should login correctly', async(inject([AuthService], (service: AuthService) => {
    service.login('admin', 'admin').subscribe(function (result) {
      expect(result).toContain('idToken');
    });
  })));
});
