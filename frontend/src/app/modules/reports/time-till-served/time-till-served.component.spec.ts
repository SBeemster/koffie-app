import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TimeTillServedComponent } from './time-till-served.component';

describe('TimeTillServedComponent', () => {
  let component: TimeTillServedComponent;
  let fixture: ComponentFixture<TimeTillServedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TimeTillServedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TimeTillServedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
