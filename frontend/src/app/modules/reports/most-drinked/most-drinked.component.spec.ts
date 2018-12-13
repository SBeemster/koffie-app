import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MostDrinkedComponent } from './most-drinked.component';

describe('MostDrinkedComponent', () => {
  let component: MostDrinkedComponent;
  let fixture: ComponentFixture<MostDrinkedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MostDrinkedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MostDrinkedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
