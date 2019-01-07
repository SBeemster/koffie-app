import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ChoiceComponent } from './choice.component';

describe('ChoiceComponent', () => {
  let component: ChoiceComponent;
  let fixture: ComponentFixture<ChoiceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ChoiceComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChoiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('Should increment the sugar count', () => {
    component.sugarCountUp();
    expect(component.sugarcnt).toBe(1);
  });

  it('Should decrement the sugar count', () => {
    component.sugarCountDown();
    expect(component.sugarcnt).toBe(0);
  });
});
