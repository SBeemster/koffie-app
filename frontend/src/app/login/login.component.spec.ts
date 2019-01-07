import { async, ComponentFixture, TestBed, inject } from '@angular/core/testing';
import { AuthService } from 'src/app/core/services/auth.service';
import { LoginComponent } from './login.component';
import { HttpClientModule } from '@angular/common/http';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { FormsModule } from '@angular/forms';

describe('LoginComponent', () => {
  let component: LoginComponent;
  let fixture: ComponentFixture<LoginComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpClientModule, HttpClientTestingModule, RouterTestingModule, FormsModule
      ],
      declarations: [LoginComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should call the Auth service login function', (inject([AuthService], (service: AuthService) => {
    component.login();
    expect(service.login('admin', 'admin')).toHaveBeenCalled();
  })));
});
